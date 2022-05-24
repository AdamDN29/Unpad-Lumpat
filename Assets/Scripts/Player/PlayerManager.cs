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

    private AudioSource coinSound;

    public static int bestScore;

    public GameObject YouLoseText;
    public static int flag;

    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
        numberOfCoins = 0;
        flag = 0;

        coinSound = GameObject.Find ("coinSound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {


                Time.timeScale = 0;
                YouLoseText.SetActive(true);
                StartCoroutine(YouLose());
                
                bestScore = GameOverSystem.BestScore;
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
        yield return new WaitForSecondsRealtime(1);
        YouLoseText.SetActive(false);
    }

    IEnumerator HighS()
    {
        yield return new WaitForSecondsRealtime(1);
        SceneManager.LoadScene("HighScore");
    }

    IEnumerator GameOverS()
    {
        yield return new WaitForSecondsRealtime(1);
        SceneManager.LoadScene("GameOver");
    }
}
