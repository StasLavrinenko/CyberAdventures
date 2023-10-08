using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueMainScript : MonoBehaviour
{
    [Space]
    [SerializeField] private Text _dialogueText;
    [SerializeField] private Text _dialogueName;

    [Space]
    [SerializeField] private Animator _startAnim;
    [SerializeField] private Animator _dialogueBoxAnim;

    private Queue<string> _sentences;

    private void Start()
    {
        _sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue _dialogue)
    {
        _dialogueBoxAnim.SetBool("BoxOpening", true);
        _startAnim.SetBool("StartOpening", false);

        _dialogueName.text = _dialogue._name;
        _sentences.Clear();

        foreach(string _sentence in _dialogue._sentences)
        {
            _sentences.Enqueue(_sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (_sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = _sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        _dialogueText.text = "";

        foreach(char letter in sentence.ToCharArray())
        {
            _dialogueText.text += letter;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        _dialogueBoxAnim.SetBool("BoxOpening", false);
    }

}
