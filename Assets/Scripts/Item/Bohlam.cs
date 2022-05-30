﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bohlam : MonoBehaviour
{
    void Start()
    {
  
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(50 * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<AudioManager>().PlaySound("PickUpCoin");
            PlayerManager.numberOfCoins += 1;
            Destroy(other.gameObject);
        }
    }
}
