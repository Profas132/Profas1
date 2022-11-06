using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void OnPause()
    {
       Time.timeScale = 0f;
    }
    public void OffPause()
    {
        Time.timeScale = 1.0f;
    }
    public void SetMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void SetGame()
    {
        SceneManager.LoadScene(0);
    }
}
