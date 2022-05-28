using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingPage : MonoBehaviour
{
    // public static int loadingTime = 0;
    public static int waitTime = 3;

     // Update is called once per frame
    void Update()
    {
        if (waitTime == 0)
        {
            SceneManager.LoadScene("Menu");
        }
        else
        {
            //loadingTime += 1 * Time.deltaTime;
            StartCoroutine(TickTack());
        }
    }

    IEnumerator TickTack()
    {
        yield return new WaitForSeconds(1);
        waitTime = waitTime - 1;
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
