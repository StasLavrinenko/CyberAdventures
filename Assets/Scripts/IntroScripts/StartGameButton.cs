using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGameButton : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
