using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class timerText : MonoBehaviour
{

    TextMeshProUGUI textBox;

    public float time = 0;
    protected float Timer;
    public int delayAmount = 1;

    void Start()
    {
        textBox = GetComponent<TextMeshProUGUI>();
        textBox.SetText("0");
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "game")
        {
            Timer += Time.deltaTime;

            if (Timer >= delayAmount)
            {
                Timer = 0f;
                time++;
                textBox.SetText("{0}", time);
            }
        }
    }
}
