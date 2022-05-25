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
            PlayerManager.numberOfCoins += 1;
            
        }

        else if (other.tag == "CoinA")
        {
            PlayerManager.numberOfCoins += 10;
        }

        else if (other.tag == "CoinB")
        {
            PlayerManager.numberOfCoins += 5;
        }

        else if (other.tag == "CoinC")
        {
            PlayerManager.numberOfCoins += 2;
        }

        else if (other.tag == "TimeObject")
        {
            GlobalTime.seconds += 15;
        }

        else if (other.tag == "GradHat")
        {
            itemKey += 1;
        }

        Destroy(other.gameObject);
    }
}
