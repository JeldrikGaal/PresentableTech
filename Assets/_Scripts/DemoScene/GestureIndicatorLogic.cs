using UnityEngine;

public class GestureIndicatorLogic : MonoBehaviour
{
    private void Awake()
    {
        MovementAnalysis.OnGestureDetected += ReactToGesture;
    }

    private void OnDestroy()
    {
        MovementAnalysis.OnGestureDetected -= ReactToGesture;
    }

    private void ReactToGesture(MovementAnalysis.Gestures gesture)
    {
        Debug.Log(gesture.ToString());
        NotificationProvider.Instance.SpawnNotification(gesture.ToString(), 1.5f);
    }
}
