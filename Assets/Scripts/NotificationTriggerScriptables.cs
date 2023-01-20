 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NotificationTriggerScriptables : MonoBehaviour
{
 

public class NotificationTriggerEvent : MonoBehaviour
{
    [Header("UI Content")]
    [SerializeField] private Text notificationTextUI;
    [SerializeField] private Image characterIconUI;

    [Header("ScriptableObject")]
    [SerializeField] private NotificationScriptable noteScriptable;

    [Header("Notification Animation")]
    [SerializeField] private Animator notificationAnim;
    private BoxCollider objectCollider;

    private void Awake()
    {

        objectCollider = gameObject.GetComponent<BoxCollider>();


    }

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player") && noteScriptable.removeAfterExit)
        {

            RemoveNotification();

        }

    }

    IEnumerator EnableNotification()
    {


        objectCollider.enabled = false;
        notificationAnim.Play("NotificationFadeIn");
        notificationTextUI.text = noteScriptable.notificationMessage;
        characterIconUI.sprite = noteScriptable.yourIcon;

        if (disableAfterTimer)
        {

            yield return new WaitForSeconds(noteScriptable.disableTimer);
            RemoveNotification();



        }









    }

    void RemoveNotification()
    {

        notificationAnim.Play("NotificationFadeOut");
        gameObject.SetActive(false);
    }

}



}
