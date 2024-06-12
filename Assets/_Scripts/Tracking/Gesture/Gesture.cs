using System;
using System.Collections.Generic;
using System.Linq;
using Mediapipe;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Gesture")]
public class Gesture : ScriptableObject
{
   public PoseTrackingInfo.LandmarkNames LandMarkToTrack;

   public TrackAnalysis.StepAnalysisParameters StepAnalysisParameters;
   public List<DirectionPercentage> DirectionPercentages;
   public List<PositionCondition> PositionConditions;
   
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

   [Serializable]
   public class PositionCondition
   {
      public enum PositionConditionDirection
      {
         Above,
         Below,
         Left,
         Right
      }

      public enum PositionConditionType
      {
         Complete,
         Start,
         End,
         StartAndEnd
      }
      
      public PoseTrackingInfo.LandmarkNames Landmark;
      public PositionConditionDirection Direction;
      public PositionConditionType Type;

      public bool CheckPositionConditionOnTrack(List<Tracker.TimeStep> track)
      {
         switch (Type)
         {
            case PositionConditionType.Complete:
               return track.All(CheckPositionConditionOnTimeStep);
            case PositionConditionType.Start:
               return CheckPositionConditionOnTimeStep(track[0]);
            case PositionConditionType.End:
               return CheckPositionConditionOnTimeStep(track[^1]);
            case PositionConditionType.StartAndEnd:
               return CheckPositionConditionOnTimeStep(track[0]) && CheckPositionConditionOnTimeStep(track[^1]);
            default:
               throw new ArgumentOutOfRangeException();
         }
      }

      private bool CheckPositionConditionOnTimeStep(Tracker.TimeStep step)
      {
         Vector3 landMarkPos = LandMarkProvider.Instance.VectorLandmarkList[PoseTrackingInfo.LandmarkIndexes[Landmark]];
         Vector3 trackedObjectPos = step.Position;

         switch (Direction)
         {
            case PositionConditionDirection.Above:
               return trackedObjectPos.y > landMarkPos.y;
            case PositionConditionDirection.Below:
               return trackedObjectPos.y < landMarkPos.y;
            case PositionConditionDirection.Left:
               return trackedObjectPos.x < landMarkPos.x;
            case PositionConditionDirection.Right:
               return trackedObjectPos.x > landMarkPos.x;
            default:
               throw new ArgumentOutOfRangeException();
            
         }
      }
      
   }
   
   
}
