using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Komik : MonoBehaviour
{
    public static bool seen = false;
    private static string fromScene;
    public void StartKomik(string fromScene)
    {
        Komik.seen = true;
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
