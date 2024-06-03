using System;
using System.Collections;
using System.Collections.Generic;
using Mediapipe;
using UnityEngine;
using Color = UnityEngine.Color;

public class PoseIndicatorLogic : MonoBehaviour
{
    // Used to Display results from PoseAnalysis
    
    [SerializeField] private List<ColorSwitchIndicator> _indicators;
    [SerializeField] private float _handToNoseMaxDistance;

    private void Update()
    {
        if (LandMarkProvider.Instance.LandmarkList.Landmark.Count <= 0)
        {
            return;
        }
        // Crossed Arms
        _indicators[0].SetColor(PoseAnalysis.AnalyzeForCrossedArms(LandMarkProvider.Instance.VectorLandmarkList, true) ? Color.green : Color.red);
            
        // Hands to close to Face
        (float leftHandNoseDistance, float rightHandNoseDistance) = PoseAnalysis.GetHandsToNoseDistance( LandMarkProvider.Instance.VectorLandmarkList);
        
        bool tooCloseTooFace = false;
        tooCloseTooFace  = leftHandNoseDistance <= _handToNoseMaxDistance || rightHandNoseDistance <= _handToNoseMaxDistance;
        _indicators[1].SetColor(tooCloseTooFace ? Color.green : Color.red);
        
        // Crossed Legs
        _indicators[2].SetColor(PoseAnalysis.AnalyzeForCrossedLegs(LandMarkProvider.Instance.VectorLandmarkList, false) ? Color.green : Color.red);
    }
}
