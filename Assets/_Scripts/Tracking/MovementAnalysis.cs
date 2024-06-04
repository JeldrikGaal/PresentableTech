using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class MovementAnalysis : MonoBehaviour
{
    [SerializeField] private List<GestureHolder> _gesturesToAnalyse;
    [SerializeField] private Dictionary<GestureHolder, float> _gestureCooldowns = new Dictionary<GestureHolder, float>();
    
    private bool _analysisStarted;
    private bool _analysisCanBeStarted;
    public static event Action<GestureHolder> OnGestureDetected;

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
        foreach (var gestureHolder in _gesturesToAnalyse)
        {
            foreach (var gesture in gestureHolder.Gestures)
            {
                await TrackingProvider.Instance.StartLandMarkTracker(gesture.LandMarkToTrack);
            }
            
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

    private void RunGestureAnalysis(GestureHolder gestureHolder)
    {
        List<bool> gestureResults = new List<bool>();
        foreach (var gesture in gestureHolder.Gestures)
        {
            List<Tracker.TimeStep> track = TrackingProvider.Instance.GetLandMarkTracker(gesture.LandMarkToTrack).GetTimeStepsFromLastSeconds(gestureHolder.Duration);
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
        }
        if (!IsGestureOnCooldown(gestureHolder))
        {
            GestureDetected(gestureHolder);
        }
    }

    private void GestureDetected(GestureHolder gesture)
    {
        OnGestureDetected?.Invoke(gesture);
        _gestureCooldowns[gesture] = gesture.Cooldown;
    }
    
    private bool IsGestureOnCooldown(GestureHolder gesture)
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
