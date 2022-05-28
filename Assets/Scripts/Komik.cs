using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Komik : MonoBehaviour
{
    private static string fromScene;

    public void StartKomik(string fromScene)
    {
        PlayerPrefs.SetInt("seenComic", 1);
        PlayerPrefs.Save();
        SceneManager.LoadScene("Komik1");
        Komik.fromScene = fromScene;
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void EndScene()
    {
        if (fromScene == "Play")
        {
            var mm = new MainMenu();
            mm.PlayGame();
        }
        else
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
