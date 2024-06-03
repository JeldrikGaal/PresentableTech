using UnityEngine;

public class NotificationProvider : MonoBehaviour
{
    public static NotificationProvider Instance { get; private set; }
    [SerializeField] private  GameObject _notificationPrefab;
    [SerializeField] private  Transform _notificationParent;
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
    }
    
    public void SpawnNotification(string text, float lifeTime)
    {
        var notification = Instantiate(_notificationPrefab, _notificationParent);
        notification.GetComponent<Notification>().Initialize(text, lifeTime);
    }
}
