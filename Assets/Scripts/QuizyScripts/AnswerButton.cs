using UnityEngine;
using TMPro;

public class AnswerButton : MonoBehaviour
{
    [SerializeField] private QuestionSetup _questionSetup;
    [SerializeField] private ScoreSystem _scoreSystem;
    [SerializeField] private TextMeshProUGUI _answerText;

    private bool _isCorrect;

    private void Start()
    {
        _questionSetup = FindObjectOfType<QuestionSetup>();
        _scoreSystem = FindObjectOfType<ScoreSystem>();
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

            if (_questionSetup._quizFolder == "ITE")
                _scoreSystem.IteScore++;
            else if (_questionSetup._quizFolder == "CyberSecurity")
                _scoreSystem.CyberScore++;

            
            Debug.Log("Correct answer");
        }
        else
        {
            _questionSetup.SwitchNextQuestion();
        }
    }

}
