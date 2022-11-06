using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pouseButton;
    [SerializeField] private GameObject pouseMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale > 0)
            {
                OnPause();
                pouseButton.SetActive(false);
                pouseMenu.SetActive(true);
                
            }
            else if (Time.timeScale == 0)
            {
                OffPause();
                pouseButton.SetActive(true);
                pouseMenu.SetActive(false);
            }
        }    
    }

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
        SceneManager.LoadScene(0);
    }
    public void SetGame()
    {
        SceneManager.LoadScene(1);
    }
}
