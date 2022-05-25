using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLength = 39;
    public int numberOfTiles = 5;
    private List<GameObject> activeTiles = new List<GameObject>();

    public Transform playerTransform;

    public static int timeObject = 0;
    public static int itemKey = 0;
    public static int ftimeObject = 3;
    public static int fitemKey = 5;

    void Start()
    {
        for (int i = 0; i < numberOfTiles; i++)
        {
            if (i == 0)
                SpawnTile(0);

           
            else
                SpawnTile(Random.Range(1, 5));
        }
        timeObject = 0;
        itemKey = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerManager.isGameStarted == true)
        {
           

            if (playerTransform.position.z - 35 > zSpawn - (numberOfTiles * tileLength))
            {
                // Time Object
                if (timeObject == ftimeObject)
                {
                    SpawnTile(Random.Range(6, 7 + 1));
                    timeObject = 0;
                    ftimeObject = 99;
                }
                else if (timeObject == 6)
                {
                    SpawnTile(Random.Range(6, 7 + 1));
                    timeObject = 0;
                }

                // Item Key
                if (itemKey == fitemKey)
                {
                    SpawnTile(Random.Range(8, 9 + 1));
                    itemKey = 0;
                    fitemKey = 99;
                }
                else if (itemKey == 8)
                {
                    SpawnTile(Random.Range(8, 9 + 1));
                    itemKey = 0;
                }


                else
                {
                    SpawnTile(Random.Range(0, 5 + 1));
                }
                timeObject += 1;
                itemKey += 1;

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
