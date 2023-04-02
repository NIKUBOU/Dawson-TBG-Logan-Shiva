using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private GameObject gameUi;

    [SerializeField]
    private GameObject deathUi;

    [SerializeField]
    private GameObject wonUi;

    [SerializeField]
    private GameObject pauseUI;

    private void Start()
    {
        //Tells the game manager to start the game
        GameManager.Instance.GameStart = true;

        RedrawUI(gameUi);
    }

    public void OpenDeathUI()
    {
        RedrawUI(deathUi);
    }

    public void OpenWonUI()
    {
        RedrawUI(wonUi);
    }

    public void NextLevel()
    {
        GameManager.Instance.LoadNext();
    }

    public void Respawn()
    {
        GameManager.Instance.ReloadScene();
    }

    public void MainMenu()
    {
        GameManager.Instance.GoBackToMainMenu();
    }

    public void PlayButton()
    {
        GameManager.Instance.TriggerGameContinue();
        RedrawUI(gameUi);
    }
    
    public void PauseButton()
    {
        GameManager.Instance.TriggerGameStop();
        RedrawUI(gameUi);

        if (pauseUI != null)
        {
            pauseUI.SetActive(true);
        }
    }

    private void RedrawUI(GameObject menu)
    {
        //Remove all UI
        if (gameUi != null)
        {
            gameUi.SetActive(false);
        }

        if (deathUi != null)
        {
            deathUi.SetActive(false);
        }

        if (wonUi != null)
        {
            wonUi.SetActive(false);
        }

        if (pauseUI != null)
        {
            pauseUI.SetActive(false);
        }

        //Add the right UI
        if (menu != null)
        {
            menu.SetActive(true);
        }
    }
}
