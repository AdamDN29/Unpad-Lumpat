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

    public static bool isGameStarted;
    public GameObject StartingText;

    public static int numberOfCoins;

    public Text scoreText;

    public static int bestScore;

    public GameObject YouLoseText;

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

                Time.timeScale = 0;
                YouLoseText.SetActive(true);
                StartCoroutine(YouLose());
                
                bestScore = PlayerPrefs.GetInt("hiScore", 0);
                if (numberOfCoins > bestScore)
                {
                    StartCoroutine(HighS());
                    
                }
                else
                {
                     StartCoroutine(GameOverS());
                }
        }

        scoreText.text = "Score : " + numberOfCoins;
        
        if (SwipeManager.tap)
        {
            isGameStarted = true;
            Destroy(StartingText);
        }
    }

    IEnumerator YouLose()
    {
        yield return new WaitForSecondsRealtime(3);
        YouLoseText.SetActive(false);
    }

    IEnumerator HighS()
    {
        yield return new WaitForSecondsRealtime(5);
        SceneManager.LoadScene("HighScore");
    }

    IEnumerator GameOverS()
    {
        yield return new WaitForSecondsRealtime(5);
        SceneManager.LoadScene("GameOver");
    }
}
