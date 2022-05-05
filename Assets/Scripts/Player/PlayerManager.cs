using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject gameOverScene1;
    public GameObject gameOverScene2;

    public static bool isGameStarted;
    public GameObject StartingText;

    public GameObject MainCanvas;

    public static int numberOfCoins;
    public static int score;
    public static int timeRun;
    public static int BestScore = 0;
    public static int BestTime = 0;
    public static int itemKey;

    public TextMeshProUGUI TextScore;
    public Text scoreText;

    public TextMeshProUGUI TimeRun;

    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
        numberOfCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            timeRun = GlobalTime.timeRun;
            score = numberOfCoins;
            itemKey = ItemKey.itemKey;


            if (score > BestScore)
            {
                BestScore = score;
                BestTime = timeRun;
            }

            var ts = TimeSpan.FromSeconds(timeRun);
            
            MainCanvas.SetActive(false);
            gameOverPanel.SetActive(true);

            if(itemKey >= 2)
            {
                gameOverScene2.SetActive(true);
            }
            else
            {
                gameOverScene1.SetActive(true);
            }

            TextScore.text = "" + score;
            TimeRun.text = string.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            Time.timeScale = 0;
        }

        scoreText.text = "Score : " + numberOfCoins;

        if (SwipeManager.tap)
        {
            isGameStarted = true;
            Destroy(StartingText);
        }
    }
}
