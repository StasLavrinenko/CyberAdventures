using UnityEngine;
using TMPro;

public class AnswerButton : MonoBehaviour
{
    [SerializeField] private QuestionSetup _questionSetup;

    [SerializeField] private TextMeshProUGUI _answerText;

    private bool _isCorrect;

    private void Start()
    {
        _questionSetup = FindObjectOfType<QuestionSetup>();
    }

    public void SetAnswerText(string _newText)
    {
        _answerText.text = _newText;
    }

    public void SetIsCorrect(bool _newBool)
    {
        _isCorrect = _newBool;
    }

    public void OnClick()
    {
        if(_isCorrect)
        {
            _questionSetup.SwitchNextQuestion();
            Debug.Log("Correct answer");
        }
        else
        {
            Debug.Log("Wrong answer");
        }
    }

}
