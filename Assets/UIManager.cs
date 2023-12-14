using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pausePanel;
    public bool isPausePanelShow;

    private void Start()
    {
        isPausePanelShow = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPausePanelShow == false)
        {
            if(pausePanel != null)
            {
                pausePanel.SetActive(true);
                isPausePanelShow = true;
                Time.timeScale = 0;
            }
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && isPausePanelShow == true)
        {
            pausePanel.SetActive(false);
            isPausePanelShow = false;
            Time.timeScale = 1;
        }
    }

    public void GoToGameplayScene()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void GoToMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
