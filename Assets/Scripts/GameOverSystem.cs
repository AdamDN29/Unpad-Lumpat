using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class GameOverSystem : MonoBehaviour
{
    public GameObject gameOverScene1;
    public GameObject gameOverScene2;

    public static int score;
    public static int timeRun;
    public static int BestScore = 0;
    public static int BestTime = 0;
    public static int itemKey;

    public TextMeshProUGUI TextScore;

    public TextMeshProUGUI TimeRun;


    // Start is called before the first frame update
    void Start()
    {
        timeRun = GlobalTime.timeRun;
        score = PlayerManager.numberOfCoins;
        itemKey = ScoreManager.itemKey;


        if (score > BestScore)
        {
            BestScore = score;
            BestTime = timeRun;
          
            PlayerPrefs.SetInt("hiScore", BestScore);
            PlayerPrefs.SetInt("hiTime", BestTime);
            PlayerPrefs.Save();
        }

        var ts = TimeSpan.FromSeconds(timeRun);

        if (itemKey >= 2)
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


}
