using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class MovementAnalysis : MonoBehaviour
{
    [SerializeField] private List<Gesture> _gesturesToAnalyse;
    [SerializeField] private Dictionary<Gesture, float> _gestureCooldowns = new Dictionary<Gesture, float>();
    
    private bool _analysisStarted;
    private bool _analysisCanBeStarted;
    public static event Action<Gesture> OnGestureDetected;

    async void Start()
    { 
        await LandMarkProvider.Instance.WaitForLandMarkData();
        _analysisCanBeStarted = true;
        TryStartAnalysis();
        InitializeGestureCooldowns();
    }
    
    async void TryStartAnalysis()
    {
        if (_analysisCanBeStarted && !_analysisStarted)
        {
            _analysisStarted = true;
            await StartTrackers();
        }
    }

    async Task StartTrackers()
    {
        foreach (var gesture in _gesturesToAnalyse)
        {
            await TrackingProvider.Instance.StartLandMarkTracker(gesture.LandMarkToTrack);
        }
    }
    
    private void InitializeGestureCooldowns()
    {
        foreach (var gesture in _gesturesToAnalyse)
        {
            _gestureCooldowns.Add(gesture, 0);
        }
    }

    private void Update()
    {
        if (IsAnalysisRunning())
        {
            Analysis();
            HandleGestureCooldowns();
        }
    }

    private bool IsAnalysisRunning()
    {
        return _analysisStarted;
    }

    private void Analysis()
    {
        foreach (var gesture in _gesturesToAnalyse)
        {
            RunGestureAnalysis(gesture);
        }
    }

    private void RunGestureAnalysis(Gesture gesture)
    {
        List<Tracker.TimeStep> track = TrackingProvider.Instance.GetLandMarkTracker(gesture.LandMarkToTrack).GetTimeStepsFromLastSeconds(gesture.Duration);
        List<TrackAnalysis.TrackStepInformation> trackStepInfo = TrackAnalysis.GetStepInformationFromTrack(track, gesture.StepAnalysisParameters);
        
        foreach (var directionPercentage in gesture.DirectionPercentages)
        {
            int count = TrackAnalysis.FoundDirections(trackStepInfo).FindAll(e => e == directionPercentage.Direction).Count;
            // If one of the needed direction percentages is not met cancel the analysis
            if ( ! (count > track.Count * gesture.GetPercentageForDirection(directionPercentage.Direction)) ) 
            {
                return;
            }
        }

        if (!IsGestureOnCooldown(gesture))
        {
            GestureDetected(gesture);
        }
    }

    private void GestureDetected(Gesture gesture)
    {
        Debug.Log(gesture.Name);
        OnGestureDetected?.Invoke(gesture);
        _gestureCooldowns[gesture] = gesture.Cooldown;
    }
    
    private bool IsGestureOnCooldown(Gesture gesture)
    {
        return _gestureCooldowns[gesture] > 0;
    }

    private void HandleGestureCooldowns()
    {
        foreach (var gesture in _gestureCooldowns.Keys.ToList())
        {
            _gestureCooldowns[gesture] -= Time.deltaTime;
        }
    }
    
    [Serializable]
    public enum MotionDirection
    {
        Left,
        Right,
        Up,
        Down,
        Unclear
    }

}
