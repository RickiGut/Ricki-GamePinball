using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public Button playButton;
    public Button creditButton;
    public Button backButton;
    public Button exitButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
        creditButton.onClick.AddListener(Credit);
        backButton.onClick.AddListener(Back);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }


    private void ExitGame()
    {
        Application.Quit();
    }

}
