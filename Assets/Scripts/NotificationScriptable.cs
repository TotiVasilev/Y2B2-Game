using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Notificationsc")]
public class NotificationScriptable : ScriptableObject

{
    [Header("Message Customisation")]
    [SerializeField] private Sprite yourIcon;
    [SerializeField] [TextArea] private string notificationMessage;

    [Header("Notification Removal")]
    [SerializeField] private bool removeAfterExit = false;
    [SerializeField] private bool disableAfterTimer = false;
    [SerializeField] float disableTimer = 1.0f;


}
