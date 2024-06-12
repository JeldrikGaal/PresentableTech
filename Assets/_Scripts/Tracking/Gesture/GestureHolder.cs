using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/GestureHolder")]
public class GestureHolder : ScriptableObject
{
    public string Name;
    public float Duration;
    public float Cooldown;
    public List<Gesture> Gestures;
    //public GestureSequence Sequence;
}

/*

*/