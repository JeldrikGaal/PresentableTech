using System;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnalysis : MonoBehaviour
{
    [SerializeField] private float _motionSensitivity;
    [SerializeField] private float _positionSensitivity;

    private float _lastRightSwipeTime = 0;
    private float _rightSwipeCooldown = 1f;

    private bool _analysisStarted;
    private bool _analysisCanBeStarted;

    public static event Action<Gestures> OnGestureDetected;

    public enum Gestures
    {
        RightSwipe,
        LeftSwipe
    }

    async void Start()
    { 
        await LandMarkProvider.Instance.WaitForLandMarkData();
        _analysisCanBeStarted = true;
        TryStartAnalysis();
    }

    private void Update()
    {
        if (IsAnalysisRunning())
        {
            Analysis();
        }
    }

    private void Analysis()
    {
        bool rightSwipeThisFrame = RightSwipeAnalysis();
    }

    public bool TryStartAnalysis()
    {
        if (_analysisCanBeStarted && !_analysisStarted)
        {
            _analysisStarted = true;
            TrackingProvider.Instance.StartLandMarkTracker(PoseTrackingInfo.LandmarkNames.RightWrist);
            return true;
        }

        return false;
    }

    private bool IsAnalysisRunning()
    {
        return _analysisStarted;
    }

    private bool RightSwipeAnalysis()
    {
        List<Tracker.TimeStep> rightWristTrack = TrackingProvider.Instance.GetLandMarkTracker(PoseTrackingInfo.LandmarkNames.RightWrist).GetTimeSteps();
        if (CheckTimestepTrackForDirection(MotionDirection.Right, rightWristTrack , _motionSensitivity, _positionSensitivity))
        {
            if (Time.time - _lastRightSwipeTime > _rightSwipeCooldown)
            {
                OnGestureDetected?.Invoke(Gestures.RightSwipe);
                _lastRightSwipeTime = Time.time;
                return true;
            }
        }

        return false;
    }

    private bool CheckTimestepTrackForDirection( MotionDirection directionToFind, List<Tracker.TimeStep> track, float motionSensitivity, float positionSensitivity)
    {
        bool horizontal = directionToFind is MotionDirection.Right or MotionDirection.Left;
        List<MotionDirection> directions = GetMotionsFromTimestepTrack(track, positionSensitivity, horizontal);
        return CheckDirectionListForValidMotion(directions, directionToFind, track.Count, motionSensitivity);
    }

    private List<MotionDirection> GetMotionsFromTimestepTrack(List<Tracker.TimeStep> track, float positionSensitivity, bool horizontal)
    {
        List<MotionDirection> directions = new List<MotionDirection>();
        if (horizontal)
        {
            for (int i = 1; i < track.Count; i++)
            {
                directions.Add(CheckDirectionHorizontal(track[i - 1].Position, track[i].Position, positionSensitivity));
            }
        }
        else
        {
            for (int i = 1; i < track.Count; i++)
            {
                directions.Add(CheckDirectionVertical(track[i - 1].Position, track[i].Position, positionSensitivity));
            }
        }

        return directions;
    }
    
    private bool CheckDirectionListForValidMotion(List<MotionDirection> list, MotionDirection direction, int trackCount, float motionSensitivity)
    {
        return list.FindAll(e => e == direction).Count > motionSensitivity * trackCount;
    }
    

    private List<MotionDirection> CheckTimestepTrackForAllDirections(List<Tracker.TimeStep> track, float motionSensitivity, float positionSensitivity)
    {
        List<MotionDirection> options = new List<MotionDirection>() { MotionDirection.Down , MotionDirection.Left, MotionDirection.Right, MotionDirection.Up};
        List<MotionDirection> foundDirections = new List<MotionDirection>();
        
        foreach (var option in options)
        {
            if (CheckTimestepTrackForDirection(option, track, motionSensitivity, positionSensitivity))
            {
                foundDirections.Add(option);
            }
        }
        return foundDirections;
    }
    
    [Serializable]
    enum MotionDirection
    {
        Left,
        Right,
        Up,
        Down,
        Unclear
    }
    
    private MotionDirection CheckDirectionHorizontal(Vector3 start, Vector3 end, float positionSensitivity)
    {
        Vector3 difference = end - start;
        if (Mathf.Abs(difference.x) > positionSensitivity)
        {
            if (difference.x > 0)
            {
                return MotionDirection.Right;
            }
            else
            {
                return MotionDirection.Left;
            }
        }

        return MotionDirection.Unclear;
        
    } 
    private MotionDirection CheckDirectionVertical(Vector3 start, Vector3 end, float positionSensitivity)
    {
        Vector3 difference = end - start;
        if (Mathf.Abs(difference.y) > positionSensitivity)
        {
            if (difference.y > 0)
            {
                return MotionDirection.Up;
            }
            else
            {
                return MotionDirection.Down;
            }
        }

        return MotionDirection.Unclear;
    }
}
