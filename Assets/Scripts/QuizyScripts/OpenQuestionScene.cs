using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenQuestionScene : MonoBehaviour
{
    public void StartQuiz()
    {
        SceneManager.LoadScene("Questions");
    }
}
