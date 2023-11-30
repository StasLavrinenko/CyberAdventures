using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenQuestionScene : MonoBehaviour
{
    [SerializeField] private string _quizScene;
    
    public void StartQuiz()
    {
        if (_quizScene.Length > 0)
        {
            SceneManager.LoadScene(_quizScene);
        }
        else
        {
            Debug.LogError("Не вказана назва сцени у потрібному полі. Вкажіть назву сцени, котру потрібно запустити");
        }
    }
}
