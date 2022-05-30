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
    public TextMeshProUGUI Times;

    public Animator animator;
    public bool onMenu;
    public int seenComic;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("hiScore", 0);
        bestTime = PlayerPrefs.GetInt("hiTime", 0);

        Time.timeScale = 1;

        animator.SetBool("onMenu", true);

        var ts = TimeSpan.FromSeconds(bestTime);

       
        Score.text = "" + bestScore;
        Times.text = string.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);

       
    }

    public void PlayGame()
    {
        
        seenComic = PlayerPrefs.GetInt("seenComic", 0);
        if (seenComic == 0)
        {
            var komik = new Komik();
            komik.StartKomik("Play");
        }
        else
        {
            ScoreManager.itemKey = 0;
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
