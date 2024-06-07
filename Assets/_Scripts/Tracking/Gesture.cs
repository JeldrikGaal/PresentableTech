using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Gesture")]
public class Gesture : ScriptableObject
{
   public PoseTrackingInfo.LandmarkNames LandMarkToTrack;

   public TrackAnalysis.StepAnalysisParameters StepAnalysisParameters;
   public List<DirectionPercentage> DirectionPercentages;
   
   [Serializable]
   public class DirectionPercentage
   {
      public MovementAnalysis.MotionDirection Direction;
      
      [Range(0,1)]
      public float MinimumPercentage = 0;
      [Range(0,1)]
      public float MaximumPercentage = 1;

      public bool CheckPercentageCondition(int foundCount, int totalCount)
      {
         return foundCount < totalCount * MaximumPercentage && foundCount > totalCount * MinimumPercentage;
      }
   }
}
