using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemKey : MonoBehaviour
{
    public static int itemKey = 0;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<BackgroundMusic>().PlaySound("item");
            itemKey += 1;
            Debug.Log(itemKey);
            Destroy(gameObject);
        }
    }
}
