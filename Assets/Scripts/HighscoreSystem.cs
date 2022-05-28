using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HighscoreSystem : MonoBehaviour
{

    public static int score;

    public TextMeshProUGUI HighscoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerManager.numberOfCoins;

        HighscoreText.text = "" + score;

    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("GameOver");
    }
}
