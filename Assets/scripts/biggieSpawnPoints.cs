using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class biggieSpawnPoints : MonoBehaviour
{

    public GameObject biggie;
    public float spawnTime;
    public float spawnStartTime;
    public Transform[] SpawnPoints;
    public int[] spawned;
    public int SpawnEnemies;


    void Start()
    {
        //med listan "spawned = new int[3]" gör jag så att det fins 3 stycken spawnpoints. 
        spawned = new int[3];
        //det här scriptet visar hur lång tid det är mellan spawnsen. 
        //spawnStartTime = 2f;
        //spawnTime = 1f;
        InvokeRepeating("spawn", spawnStartTime, spawnTime);

    }

    void spawn()
    {
        //det här scriptet göt så att något spawnas på en spawnpoint.
        if (SpawnEnemies < SpawnPoints.Length)
        {
            int spawnPointIndex;
            do
            {

                // jag har gjort en while loop som atltid kollar om det finns en plats för enemy att spawna på. om det finns en plats
                //kommer den platsen bli uptagen och ingen enemy kan spawna på denna position om inte enemy försviner. 
                spawnPointIndex = Random.Range(0, SpawnPoints.Length);
            } while (spawned[spawnPointIndex] > 0);
            spawned[spawnPointIndex] = 1;

            Instantiate(biggie, SpawnPoints[spawnPointIndex].position, SpawnPoints[spawnPointIndex].rotation);
            SpawnEnemies++;
        }


    }


}
