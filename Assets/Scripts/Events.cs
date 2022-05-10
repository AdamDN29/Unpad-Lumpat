using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
    public void ReplayGame()
    {
        ItemKey.itemKey = 0;
        GlobalTime.seconds = 30;
        GlobalTime.timeRun = 0;
        GlobalTime.timeObject = 0;
        SceneManager.LoadScene("Level");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
