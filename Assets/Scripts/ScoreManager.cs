using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int itemKey = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bohlam")
        {
            FindObjectOfType<BackgroundMusic>().PlaySound("PickUpCoin");
            PlayerManager.numberOfCoins += 1;    
        }

        else if (other.tag == "CoinA")
        {
            FindObjectOfType<BackgroundMusic>().PlaySound("PickUpCoin2");
            PlayerManager.numberOfCoins += 10;
        }

        else if (other.tag == "CoinB")
        {
            FindObjectOfType<BackgroundMusic>().PlaySound("PickUpCoin2");
            PlayerManager.numberOfCoins += 5;
        }

        else if (other.tag == "CoinC")
        {
            FindObjectOfType<BackgroundMusic>().PlaySound("PickUpCoin2");
            PlayerManager.numberOfCoins += 2;
        }

        else if (other.tag == "TimeObject")
        {
<<<<<<< Updated upstream
            FindObjectOfType<AudioManager>().PlaySound("time");
            GlobalTime.seconds += 14;
=======
            FindObjectOfType<BackgroundMusic>().PlaySound("time");
            GlobalTime.seconds += 15;
>>>>>>> Stashed changes
        }

        else if (other.tag == "GradHat")
        {
            FindObjectOfType<BackgroundMusic>().PlaySound("item");
            PlayerManager.numberOfCoins += 25;
            itemKey += 1;
        }

        Destroy(other.gameObject);
    }
}
