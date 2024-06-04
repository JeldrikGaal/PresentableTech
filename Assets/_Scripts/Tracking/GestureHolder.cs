using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/GestureHolder")]
public class GestureHolder : ScriptableObject
{
    public string Name;
    public float Duration;
    public float Cooldown;
    public List<Gesture> Gestures;
   
}