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

    private void Start()
    {
        //Tells the game manager to start the game
        GameManager.Instance.GameStart = true;

        if (gameUi != null)
        {
            //Add the game Ui
            gameUi.SetActive(true);
        }

        if (deathUi != null)
        {
            deathUi.SetActive(false);
        }

        if (wonUi != null)
        {
            wonUi.SetActive(false);
        }
    }

    public void OpenDeathUI()
    {
        if (gameUi != null)
        {
            //Removes the game Ui
            gameUi.SetActive(false);
        }

        if (deathUi != null)
        {
            //Add the death Ui
            deathUi.SetActive(true);
        }

        if (wonUi != null)
        {
            wonUi.SetActive(false);
        }
    }

    public void OpenWonUI()
    {
        if (gameUi != null)
        {
            //Removes the game Ui
            gameUi.SetActive(false);
        }

        if (deathUi != null)
        {
            //Add the death Ui
            deathUi.SetActive(false);
        }

        if (wonUi != null)
        {
            wonUi.SetActive(true);
        }
    }

    public void NextLevel()
    {
        GameManager.Instance.LoadNext();
    }

    public void MainMenu()
    {
        GameManager.Instance.GoBackToMainMenu();
    }
}
