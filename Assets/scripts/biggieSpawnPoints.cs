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
        //med listan "spawned = new int[3]" g�r jag s� att det fins 3 stycken spawnpoints. 
        spawned = new int[3];
        //det h�r scriptet visar hur l�ng tid det �r mellan spawnsen. 
        //spawnStartTime = 2f;
        //spawnTime = 1f;
        InvokeRepeating("spawn", spawnStartTime, spawnTime);

    }

    void spawn()
    {
        //det h�r scriptet g�t s� att n�got spawnas p� en spawnpoint.
        if (SpawnEnemies < SpawnPoints.Length)
        {
            int spawnPointIndex;
            do
            {

                // jag har gjort en while loop som atltid kollar om det finns en plats f�r enemy att spawna p�. om det finns en plats
                //kommer den platsen bli uptagen och ingen enemy kan spawna p� denna position om inte enemy f�rsviner. 
                spawnPointIndex = Random.Range(0, SpawnPoints.Length);
            } while (spawned[spawnPointIndex] > 0);
            spawned[spawnPointIndex] = 1;

            Instantiate(biggie, SpawnPoints[spawnPointIndex].position, SpawnPoints[spawnPointIndex].rotation);
            SpawnEnemies++;
        }


    }


}
