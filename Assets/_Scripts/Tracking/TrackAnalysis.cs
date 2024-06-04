using System;
using System.Collections.Generic;
using UnityEngine;

public static class TrackAnalysis
{
    
    [Serializable]
    public class StepAnalysisParameters
    {
        public Vector2 XLimits;
        public Vector2 YLimits;
    }

    [Serializable]
    public class TrackStepInformation
    {
        public Tracker.TimeStep Step1;
        public Tracker.TimeStep Step2;
        public float Duration;
        public float StartTime;
        public float EndTime;
        public Vector3 Distance;
        public StepAnalysisParameters StepParameters;
        public List<MovementAnalysis.MotionDirection> Directions;

        public TrackStepInformation(Tracker.TimeStep step1, Tracker.TimeStep step2, StepAnalysisParameters stepParameters)
        {
            Step1 = step1;
            Step2 = step2;
            StartTime = Step1.Time;
            EndTime   = Step2.Time;
            Duration  = Step2.Time - Step1.Time;
            Distance = Step2.Position - Step1.Position;
            StepParameters = stepParameters;
            Directions = GetDirections();
        }

        private List<MovementAnalysis.MotionDirection> GetDirections()
        {
            List<MovementAnalysis.MotionDirection> foundDirections = new List<MovementAnalysis.MotionDirection>();
            
            // Vertical Motions
            if (Mathf.Abs(Distance.y) > StepParameters.YLimits.x && Mathf.Abs(Distance.y) > StepParameters.YLimits.y)
            {
                foundDirections.Add(Distance.y > 0 ? MovementAnalysis.MotionDirection.Down : MovementAnalysis.MotionDirection.Up);
            }
            
            // Horizontal Motions
            if (Mathf.Abs(Distance.x) > StepParameters.XLimits.x && Mathf.Abs(Distance.x) > StepParameters.XLimits.y)
            {
                foundDirections.Add(Distance.x > 0 ? MovementAnalysis.MotionDirection.Right : MovementAnalysis.MotionDirection.Left);
            }

            if (foundDirections.Count == 0)
            {
                foundDirections.Add(MovementAnalysis.MotionDirection.Unclear);
            }
            
            return foundDirections;
        }
    }

    public static List<TrackStepInformation> GetStepInformationFromTrack(List<Tracker.TimeStep> track ,StepAnalysisParameters parameters)
    {
        List<TrackStepInformation> trackStepInformation = new List<TrackStepInformation>();
        
        for (int i = 0; i < track.Count - 1; i++)
        {
            trackStepInformation.Add(new TrackStepInformation(track[i], track[i+1], parameters));
        }

        return trackStepInformation;
    }
    
    public static List<MovementAnalysis.MotionDirection> FoundDirections(List<TrackStepInformation> trackStepInformation)
    {
        List<MovementAnalysis.MotionDirection> foundDirections = new List<MovementAnalysis.MotionDirection>();
        
        foreach (var step in trackStepInformation)
        {
            foundDirections.AddRange(step.Directions);
        }

        return foundDirections;
    }
}
