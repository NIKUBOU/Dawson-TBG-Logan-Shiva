using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.EventSystems.EventTrigger;

public class GameManager : MonoBehaviour
{
    private int previousScore = 0;

    private float currentTimer = 0;

    private static GameManager instance;

    private int deaths;

    private int score = 0;

    public int Deaths { get { return deaths; } set { deaths = value; } }

    public int Score { get { return score; } set { score = value; } }

    public float CurrentTimer
    {
        get { return currentTimer; }
    }

    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    private void Start()
    {
        deaths = 0;
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        Timer();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadNext();
        }
    }

    void Timer()
    {
        currentTimer += Time.deltaTime;
    }

    //Scene management stuff
    public void LoadNext()
    {
        previousScore = score;
        if (SceneManager.GetActiveScene().buildIndex >= SceneManager.sceneCount)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void TriggerGameOver()
    {
        //canvasMenu.OpenDeathUI();
        score = previousScore;
        deaths++;
    }
}
