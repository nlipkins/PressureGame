using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text gameTimerText;

    public float gameTimer = 0f;

    public PlayerController pcs;

    // Start is called before the first frame update
    void Start()
    {
        pcs = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pcs.gameOver == false)
        {
            gameTimer += Time.deltaTime * 30;

            int seconds = (int)(gameTimer % 60);
            int minutes = (int)(gameTimer / 60) % 60;
            int hours = (int)(gameTimer / 3600) % 24;

            string timerString = string.Format("{0:0}:{1:00}:{2:00}", hours, minutes, seconds);

            gameTimerText.text = timerString;
        }
    }
}
