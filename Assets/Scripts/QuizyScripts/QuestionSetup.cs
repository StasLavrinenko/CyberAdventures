using UnityEngine;
using TMPro;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class QuestionSetup : MonoBehaviour
{

    [SerializeField] private List<QuestionData> _questions;

    [SerializeField] private TextMeshProUGUI _questionText;
    [SerializeField] private TextMeshProUGUI _categoryText;
    [SerializeField] private AnswerButton[] _answerButtons;
    [SerializeField] private ScoreSystem _scoreSystem;

    [SerializeField] private int _correctAnswerChoice;

    public string _quizFolder;


    [Header("Events")]
    public UnityEvent EndQuizEvent;

    private QuestionData _currentQuestion;


    private void Awake()
    {
        GetQuestionAssets();
    }

    private void Start()
    {
        SelectNewQuestions();
        SetQuestionsValues();
        SetAnswerValues();
    }

    private void GetQuestionAssets()
    {
        _questions = new List<QuestionData>(Resources.LoadAll<QuestionData>(_quizFolder));
    }

    private void SelectNewQuestions()
    {
        int _randomQuestionIndex = Random.Range(0, _questions.Count);
        _currentQuestion = _questions[_randomQuestionIndex];
        _questions.RemoveAt(_randomQuestionIndex);
    }

    private void SetQuestionsValues()
    {
        _questionText.text = _currentQuestion.Question;
        _categoryText.text = _currentQuestion.Category;
    }

    private void SetAnswerValues()
    {
        List<string> _answers = RandomizeAnswers(new List<string>(_currentQuestion.Answers));

        for(int i = 0; i < _answerButtons.Length; i++)
        {

            bool _isCorrect = false;

            if(i == _correctAnswerChoice)
            {
                _isCorrect = true;
            }

            _answerButtons[i].SetIsCorrect(_isCorrect);
            _answerButtons[i].SetAnswerText(_answers[i]);

        }

    }



    private List<string> RandomizeAnswers(List<string> _originalList)
    {
        bool _correctAnswerChosen = false;

        List<string> _newList = new List<string>();

        for(int i = 0; i < _answerButtons.Length; i++)
        {
            int _random = Random.Range(0, _originalList.Count);

            if(_random == 0 && !_correctAnswerChosen)
            {
                _correctAnswerChoice = i;
                _correctAnswerChosen = true;
            }

            _newList.Add(_originalList[_random]);
            _originalList.RemoveAt(_random);

        }

        return _newList;

    }

    public void SwitchNextQuestion()
    {
        if(_questions.Count > 0)
        {
            SelectNewQuestions();
            SetQuestionsValues();
            SetAnswerValues();
        }
        else
        {
            EndQuizEvent?.Invoke();
        }
    }

}
