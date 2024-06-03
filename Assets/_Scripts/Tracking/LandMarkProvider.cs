using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mediapipe;
using UnityEngine;

public class LandMarkProvider : MonoBehaviour
{
    public NormalizedLandmarkList LandmarkList { get; private set; } = new NormalizedLandmarkList();
    public List<Vector2> VectorLandmarkList { get; private set; } = new List<Vector2>();
    public static LandMarkProvider Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        PresentationPoseTrackingSolution.ReceivedLandmarks += SaveLandMarks;
    }
    
    private void OnDestroy()
    {
        PresentationPoseTrackingSolution.ReceivedLandmarks -= SaveLandMarks;
    }
    
    private void SaveLandMarks(NormalizedLandmarkList list)
    {
        LandmarkList = list;
        VectorLandmarkList = NormalizedLandmarkListToVector2List(list);
    }
    
    private static List<Vector2> NormalizedLandmarkListToVector2List(NormalizedLandmarkList landmarkList)
    {
        return landmarkList.Landmark.Select(landmark => new Vector2(landmark.X, landmark.Y)).ToList();
    }
    
    public async Task WaitForLandMarkData()
    {
        while (!LandMarkDataAvailable())
        {
            await Task.Delay(500);
        }
    }

    private bool LandMarkDataAvailable()
    {
        return VectorLandmarkList.Count > 0;
    }
}
