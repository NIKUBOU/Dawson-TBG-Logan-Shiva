using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Scoreboard : MonoBehaviour
{
    private TextMeshProUGUI textField;

    private void Start()
    {
        textField = GetComponentInChildren<TextMeshProUGUI>();
    }

    //Update is called once per frame
    void Update()
    {
        textField.text ="Time: " + GameManager.Instance.CurrentTimer.ToString("f2") +
                        "     Enemy KIA: " + GameManager.Instance.Score + 
                        "     Deaths: " + GameManager.Instance.Deaths;
    }
}
