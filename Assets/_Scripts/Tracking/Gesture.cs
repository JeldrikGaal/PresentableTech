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
      public float Percentage;
      public ComparisonOperator Operator;
      
      public enum ComparisonOperator
      {
         LesserThen,
         GreaterThen
      }

      public bool CheckPercentageCondition(int foundCount, int totalCount)
      {
         switch (Operator)
         {
            case ComparisonOperator.LesserThen:
               return foundCount < totalCount * Percentage;
            case ComparisonOperator.GreaterThen:
               return foundCount > totalCount * Percentage;
            default:
               throw new ArgumentOutOfRangeException();
         }
      }
   }

   public float GetPercentageForDirection(MovementAnalysis.MotionDirection direction)
   {
      return DirectionPercentages.Find(e => e.Direction == direction).Percentage;
   }
}
