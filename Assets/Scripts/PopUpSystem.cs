using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpSystem : MonoBehaviour
{
    public GameObject PopUpBox;
    public Animator animator;
    public TMP_Text popUpText;

    public void PopUp(string text)
    {

        PopUpBox.SetActive(true);
        popUpText.text = text;
        animator.SetTrigger("Watch out! Tempature in the room is too hot");

    }
}


