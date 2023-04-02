using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EndScreenMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject scoreboard;
    void Start()
    {
        //Scoreboard changes
        scoreboard.GetComponent<TextMeshProUGUI>().text = "Time: " + GameManager.Instance.CurrentTimer.ToString("f2") + "     Score: " + GameManager.Instance.Score + "     Lost Soldiers: " + (GameManager.Instance.Deaths);
    }
}
