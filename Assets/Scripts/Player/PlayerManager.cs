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

    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
        numberOfCoins = 0;

        coinSound = GameObject.Find ("coinSound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            SceneManager.LoadScene("GameOver");
        }

        scoreText.text = "Score : " + numberOfCoins;

        

        if (SwipeManager.tap)
        {
            isGameStarted = true;
            Destroy(StartingText);
        }
    }
}
