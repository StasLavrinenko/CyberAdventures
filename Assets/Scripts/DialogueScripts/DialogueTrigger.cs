using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Animator _startAnim;
    [SerializeField] private DialogueMainScript _dm;

    private void OnTriggerEnter(Collider other)
    {
        _startAnim.SetBool("StartOpening", true);
    }

    private void OnTriggerExit(Collider other)
    {
        _startAnim.SetBool("StartOpening", false);
        _dm.EndDialogue();
    }
}
