using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Gesture")]
public class Gesture : ScriptableObject
{
   public string Name;
   public float Duration;
   public PoseTrackingInfo.LandmarkNames LandMarkToTrack;
   public float Cooldown;

   public TrackAnalysis.StepAnalysisParameters StepAnalysisParameters;
   public List<DirectionPercentage> DirectionPercentages;
   
   [Serializable]
   public class DirectionPercentage
   {
      public MovementAnalysis.MotionDirection Direction;
      [Range(0,1)]
      public float Percentage;
   }

   public float GetPercentageForDirection(MovementAnalysis.MotionDirection direction)
   {
      return DirectionPercentages.Find(e => e.Direction == direction).Percentage;
   }
}
