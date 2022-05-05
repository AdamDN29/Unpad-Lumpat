using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTime : MonoBehaviour
{
    public GameObject timeDisplay;
    public GameObject TimeOutText;
    public static int seconds = 30;
    public static int timeRun = 0;
    public static int timeObject = 0;
    public bool deductingTime;

    // Update is called once per frame
    void Update()
    {
        
        if (!PlayerManager.isGameStarted)
        {
            return;
        }


        if (seconds == 0)
        {         
            seconds = 0;
            TimeOutText.SetActive(true);
            StartCoroutine(TimeOut());
            
        }
        else if(seconds == -1)
        {
            seconds = 60;
            PlayerManager.gameOver = true;
        }
        else
        {
            if (deductingTime == false)
            {
                deductingTime = true;
                StartCoroutine(DeductSecond());
            }
        }
        
    }

    IEnumerator DeductSecond()
    {
        yield return new WaitForSeconds(1);
        seconds -= 1;
        timeRun += 1;
        timeObject += 1; 
        timeDisplay.GetComponent<Text>().text = "Time   : " + seconds;
        deductingTime = false;
    }

    IEnumerator TimeOut()
    {       
        yield return new WaitForSeconds(1);
        TimeOutText.SetActive(false);
        seconds = -1;
    }

}
