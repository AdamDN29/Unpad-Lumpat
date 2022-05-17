using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class MainMenu : MonoBehaviour
{
    public static int bestScore;
    public static int bestTime;

    public TextMeshProUGUI Score;
    public TextMeshProUGUI Time;

    void Start()
    {
        bestScore = GameOverSystem.BestScore;
        bestTime = GameOverSystem.BestTime;

        var ts = TimeSpan.FromSeconds(bestTime);

        Score.text = "" + bestScore;
        Time.text = string.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
    }

    public void PlayGame()
    {
        if (Komik.seen == false)
        {
            var komik = new Komik();
            komik.StartKomik("Play");
        }
        else
        {
            ItemKey.itemKey = 0;
            GlobalTime.seconds = 30;
            GlobalTime.timeRun = 0;
            GlobalTime.timeObject = 0;
            SceneManager.LoadScene("Level");
        }
    }

    public void LihatKomik()
    {
        var komik = new Komik();
        komik.StartKomik("Setting");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
