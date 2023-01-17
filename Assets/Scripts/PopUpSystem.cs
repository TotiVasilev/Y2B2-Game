using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpWindow : MonoBehaviour
{

    public TMP_Text popupText;

    private GameObject window;
    private Animator popupAnimator;

        private Queue<string> popupQueue;
    private bool IsActive;
    private Coroutine queueChecker;


    public void Start()
    {

        window = transform.GetChild(0).gameObject;
            popupAnimator = window.GetComponent<Animator>();
        window.SetActive(false);
        popupQueue = new Queue<string>();

    }

    public void AddToQueu(string text)
    {
        popupQueue.Enqueue(text);
        if (queueChecker == null)
            queueChecker = StartCoroutine(checkQueue());

    }


    private void ShowPopup(string text)
    {

        IsActive = true;
        window.SetActive(true);
        popupText.text = text;
        popupAnimator.Play("PopupAnimation");

    }

    private IEnumerator CheckQueu()
    {
        do
        {

            ShowPopup(popupQueue.Dequeue());
           do {

             yield return null;

            } while (!popupAnimator.GetCurrentAnimatorStateInfo(0).IsTag("idle"));


        } while (popupQueue.Count > 0);
        IsActive = false;
        window.SetActive(false);
        queueChecker = 0;




    }



}



   


