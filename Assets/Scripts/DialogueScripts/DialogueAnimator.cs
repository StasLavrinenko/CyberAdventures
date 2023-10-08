using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnimator : MonoBehaviour
{
    [SerializeField] private Dialogue _dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueMainScript>().StartDialogue(_dialogue);
    }
}
