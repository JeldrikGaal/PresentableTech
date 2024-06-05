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
    public GestureSequence Sequence;
}

[Serializable]
public class GestureSequence
{
    public List<GestureSequenceElement> Elements;
    private int _currentElement;

    private List<GestureSequenceElement> GetCurrentElements()
    {
        return Elements.FindAll(e => e.Position == _currentElement);
    }
    
    private List<GestureSequenceElement> GetElementsAtPos(int position)
    {
        return Elements.FindAll(e => e.Position == position);
    }

    public void NextElement()
    {
        _currentElement++;
    }

    private int GetHighestPosition()
    {
        return Elements.Select(element => element.Position).Prepend(0).Max();
    }

    public bool IsSequenceFinished()
    {
        return _currentElement >= GetHighestPosition();
    }
}

[Serializable]
public class GestureSequenceElement
{
    public Gesture Gesture;
    public int Position;
}