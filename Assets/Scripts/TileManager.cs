using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLength = 55;
    public int numberOfTiles = 5;
    private List<GameObject> activeTiles = new List<GameObject>();

    public Transform playerTransform;

    public static int timeObject = 0;
    public static int itemKey = 0;
    public static int tileCount = 0;
    public static int ftimeObject = 3;
    public static int fitemKey = 5;

    void Start()
    {
        for (int i = 0; i < numberOfTiles; i++)
        {
            if (i == 0)
            {
                SpawnTile(0);
            }
                
            else if (i == 1)
            {
                SpawnTile(1);
            }
                
            else if (i == 2)
            {
                SpawnTile(2);
            }
               
            else
                SpawnTile(Random.Range(7, 16 + 1));
        }
        timeObject = 0;
        itemKey = 0;
        tileCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerManager.isGameStarted == true)
        {
           

            if (playerTransform.position.z - 45 > zSpawn - (numberOfTiles * tileLength))
            {
                // Time Object
                if (timeObject == ftimeObject)
                {
                    SpawnTile(Random.Range(3, 4 + 1));
                    timeObject = 0;
                    ftimeObject = 99;
                }
                else if (timeObject == 6)
                {
                    SpawnTile(Random.Range(3, 4 + 1));
                    timeObject = 0;
                }

                // Item Key
                if (itemKey == fitemKey)
                {
                    SpawnTile(Random.Range(5, 6 + 1));
                    itemKey = 0;
                    fitemKey = 99;
                }
                else if (itemKey == 8)
                {
                    SpawnTile(Random.Range(5, 6 + 1));
                    itemKey = 0;
                }

                // Normal
                else if (tileCount <= 12)
                {
                    SpawnTile(Random.Range(7, 16 + 1));
                }

                else if (tileCount >= 13)
                {
                    SpawnTile(Random.Range(17, 26 + 1));
                }
                if (tileCount == 25)
                {
                    tileCount = 0;
                }
                timeObject += 1;
                itemKey += 1;
                tileCount += 1;


                DeleteTile();
            }


        }
    
    }

    public void SpawnTile (int tileIndex)
    {
        GameObject go = Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(go);
        zSpawn += tileLength;
    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
