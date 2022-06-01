using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
    public void ReplayGame()
    {
        FindObjectOfType<BackgroundMusic>().PlaySound("MainTheme");
        ScoreManager.itemKey = 0;
        GlobalTime.seconds = 30;
        GlobalTime.timeRun = 0;
        GlobalTime.timeObject = 0;
        SceneManager.LoadScene("Level");
    }

    public void MainMenu()
    {
        FindObjectOfType<BackgroundMusic>().PlaySound("MainTheme");
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
