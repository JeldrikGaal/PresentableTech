using System.Collections.Generic;
using Mediapipe;

public static class PoseTrackingInfo
{
    // Removed some connections that are not needed to be visualised for HyTea
    public static readonly List<(int, int)> Connections = new List<(int, int)>
    {
        /* // Left Eye
        (0, 1),
        (1, 2),
        (2, 3),
        (3, 7),
        // Right Eye
        (0, 4),
        (4, 5),
        (5, 6),
        (6, 8),
        // Lips
        (9, 10), */
        // Left Arm
        (11, 13),
        (13, 15),
        // Left Hand
        (15, 17),
        (15, 19),
        (15, 21),
        (17, 19),
        // Right Arm
        (12, 14),
        (14, 16),
        // Right Hand
        (16, 18),
        (16, 20),
        (16, 22),
        (18, 20),
        // Torso
        (11, 12),
        (12, 24),
        (24, 23),
        (23, 11),
        // Left Leg
        (23, 25),
        (25, 27),
        (27, 29),
        (27, 31),
        (29, 31),
        // Right Leg
        (24, 26),
        (26, 28),
        (28, 30),
        (28, 32),
        (30, 32),
    };

    public enum LandmarkNames
    {
        Nose,
        LeftEyeInner,
        LeftEye,
        LeftEyeOuter,
        RightEyeInner,
        RightEye,
        RightEyeOuter,
        LeftEar,
        RightEar,
        MouthLeft,
        MouthRight,
        LeftShoulder,
        RightShoulder,
        LeftElbow,
        RightElbow,
        LeftWrist,
        RightWrist,
        LeftPinky,
        RightPinky,
        LeftIndex,
        RightIndex,
        LeftThumb,
        RightThumb,
        LeftHip,
        RightHip,
        LeftKnee,
        RightKnee,
        LeftAnkle,
        RightAnkle,
        LeftHeel,
        RightHeel,
        LeftFootIndex,
        RightFootIndex
    }
    
    public static readonly Dictionary<LandmarkNames, int> LandmarkIndexes = new Dictionary<LandmarkNames, int>()
    {
        { LandmarkNames.Nose, 0 },
        { LandmarkNames.LeftEyeInner, 1 },
        { LandmarkNames.LeftEye, 2 },
        { LandmarkNames.LeftEyeOuter, 3 },
        { LandmarkNames.RightEyeInner, 4 },
        { LandmarkNames.RightEye, 5 },
        { LandmarkNames.RightEyeOuter, 6 },
        { LandmarkNames.LeftEar, 7 },
        { LandmarkNames.RightEar, 8 },
        { LandmarkNames.MouthLeft, 9 },
        { LandmarkNames.MouthRight, 10 },
        { LandmarkNames.LeftShoulder, 11 },
        { LandmarkNames.RightShoulder, 12 },
        { LandmarkNames.LeftElbow, 13 },
        { LandmarkNames.RightElbow, 14 },
        { LandmarkNames.LeftWrist, 15 },
        { LandmarkNames.RightWrist, 16 },
        { LandmarkNames.LeftPinky, 17 },
        { LandmarkNames.RightPinky, 18 },
        { LandmarkNames.LeftIndex, 19 },
        { LandmarkNames.RightIndex, 20 },
        { LandmarkNames.LeftThumb, 21 },
        { LandmarkNames.RightThumb, 22 },
        { LandmarkNames.LeftHip, 23 },
        { LandmarkNames.RightHip, 24 },
        { LandmarkNames.LeftKnee, 25 },
        { LandmarkNames.RightKnee, 26 },
        { LandmarkNames.LeftAnkle, 27 },
        { LandmarkNames.RightAnkle, 28 },
        { LandmarkNames.LeftHeel, 29 },
        { LandmarkNames.RightHeel, 30 },
        { LandmarkNames.LeftFootIndex, 31 },
        { LandmarkNames.RightFootIndex, 32 },
    };

       public enum BodyPart
        {
            RightHand,
            LeftHand,
            Head,
            Shoulder,
            Hip,
            Elbow,
            Knee,
            Ankle,
            Heel,
            FootIndex,
            LeftLeg,
            RightLeg,
            LeftArm,
            RightArm
        }

        public static readonly Dictionary<BodyPart, List<int>> BodyPartIndexes = new Dictionary<BodyPart, List<int>>
        {
            {BodyPart.RightHand, new List<int> {LandmarkIndexes[LandmarkNames.RightWrist], LandmarkIndexes[LandmarkNames.RightPinky], LandmarkIndexes[LandmarkNames.RightIndex], LandmarkIndexes[LandmarkNames.RightThumb]}},
            {BodyPart.LeftHand, new List<int> {LandmarkIndexes[LandmarkNames.LeftWrist], LandmarkIndexes[LandmarkNames.LeftPinky], LandmarkIndexes[LandmarkNames.LeftIndex], LandmarkIndexes[LandmarkNames.LeftThumb]}},
            {BodyPart.Head, new List<int> {LandmarkIndexes[LandmarkNames.Nose], LandmarkIndexes[LandmarkNames.LeftEyeInner], LandmarkIndexes[LandmarkNames.LeftEye], LandmarkIndexes[LandmarkNames.LeftEyeOuter], LandmarkIndexes[LandmarkNames.RightEyeInner], LandmarkIndexes[LandmarkNames.RightEye], LandmarkIndexes[LandmarkNames.RightEyeOuter], LandmarkIndexes[LandmarkNames.LeftEar], LandmarkIndexes[LandmarkNames.RightEar], LandmarkIndexes[LandmarkNames.MouthLeft], LandmarkIndexes[LandmarkNames.MouthRight]}},
            {BodyPart.Shoulder, new List<int> {LandmarkIndexes[LandmarkNames.LeftShoulder], LandmarkIndexes[LandmarkNames.RightShoulder]}},
            {BodyPart.Hip, new List<int> {LandmarkIndexes[LandmarkNames.LeftHip], LandmarkIndexes[LandmarkNames.RightHip]}},
            {BodyPart.Elbow, new List<int> {LandmarkIndexes[LandmarkNames.LeftElbow], LandmarkIndexes[LandmarkNames.RightElbow]}},
            {BodyPart.Knee, new List<int> {LandmarkIndexes[LandmarkNames.LeftKnee], LandmarkIndexes[LandmarkNames.RightKnee]}},
            {BodyPart.Ankle, new List<int> {LandmarkIndexes[LandmarkNames.LeftAnkle], LandmarkIndexes[LandmarkNames.RightAnkle]}},
            {BodyPart.Heel, new List<int> {LandmarkIndexes[LandmarkNames.LeftHeel], LandmarkIndexes[LandmarkNames.RightHeel]}},
            {BodyPart.FootIndex, new List<int> {LandmarkIndexes[LandmarkNames.LeftFootIndex], LandmarkIndexes[LandmarkNames.RightFootIndex]}},
            {BodyPart.LeftLeg, new List<int> {LandmarkIndexes[LandmarkNames.LeftHip], LandmarkIndexes[LandmarkNames.LeftKnee], LandmarkIndexes[LandmarkNames.LeftAnkle], LandmarkIndexes[LandmarkNames.LeftHeel], LandmarkIndexes[LandmarkNames.LeftFootIndex]}},
            {BodyPart.RightLeg, new List<int> {LandmarkIndexes[LandmarkNames.RightHip], LandmarkIndexes[LandmarkNames.RightKnee], LandmarkIndexes[LandmarkNames.RightAnkle], LandmarkIndexes[LandmarkNames.RightHeel], LandmarkIndexes[LandmarkNames.RightFootIndex]}},
            {BodyPart.LeftArm, new List<int> {LandmarkIndexes[LandmarkNames.LeftShoulder], LandmarkIndexes[LandmarkNames.LeftElbow], LandmarkIndexes[LandmarkNames.LeftWrist]}},
            {BodyPart.RightArm, new List<int> {LandmarkIndexes[LandmarkNames.RightShoulder], LandmarkIndexes[LandmarkNames.RightElbow], LandmarkIndexes[LandmarkNames.RightWrist]}}
        };

        public static List<BodyPart> GetVisibleBodyParts(LandmarkList landmarkList)
        {
            List<BodyPart> visibleBodyParts = new List<BodyPart>();

            foreach (var bodyPart in BodyPartIndexes)
            {
                foreach (var landmarkIndex in bodyPart.Value)
                {
                    if (landmarkList.Landmark[landmarkIndex].Visibility > 0.5f)
                    {
                        visibleBodyParts.Add(bodyPart.Key);
                        break;
                    }
                }
            }

            return visibleBodyParts;
        }
        
        public static List<BodyPart> GetVisibleBodyParts(NormalizedLandmarkList landmarkList)
        {
            List<BodyPart> visibleBodyParts = new List<BodyPart>();

            foreach (var bodyPart in BodyPartIndexes)
            {
                bool foundBodyPart = true;
                foreach (var landmarkIndex in bodyPart.Value)
                {
                    if (landmarkList.Landmark[landmarkIndex].Visibility < 0.9f)
                    {
                        foundBodyPart = false;
                        break;
                    }
                }
                if (foundBodyPart) visibleBodyParts.Add(bodyPart.Key);
            }

            return visibleBodyParts;
        }
    
}
