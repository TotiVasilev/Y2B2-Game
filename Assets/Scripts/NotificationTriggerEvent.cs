using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NotificationTriggerEvent : MonoBehaviour
{
    [Header("UI Content")]
    [SerializeField] private Text notificationTextUI;
    [SerializeField] private Image characterIconUI;

    [Header("Message Customisation")]
    [SerializeField] private Sprite exclamationmark;
    [SerializeField] private string notificationMessage;

    [Header("Notification Removal")]
    [SerializeField] private bool removeAfterExit = false;
    [SerializeField] private bool disableAfterTimer = false;
    [SerializeField] float disableTimer = 3f;

    [Header("Notification Animation")]
    [SerializeField] private Animator notificationAnim;
    private BoxCollider objectCollider;

    private void Awake()
    {
        objectCollider = gameObject.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(EnableNotification());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && removeAfterExit)
        {
            RemoveNotification();
        }
    }

    IEnumerator EnableNotification()
    {
        objectCollider.enabled = false;
        notificationAnim.Play("NotificationFadeOut");
        notificationTextUI.text = notificationMessage;
        if (exclamationmark != null)
        {
        characterIconUI.sprite = exclamationmark;
        }
        yield return new WaitForSeconds(disableTimer);
        RemoveNotification();       
    }

    void RemoveNotification()
    {

        notificationAnim.Play("NotificationFadeIn");
        gameObject.SetActive(false);
    }

}

