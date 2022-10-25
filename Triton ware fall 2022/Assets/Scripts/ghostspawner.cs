using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostspawner : MonoBehaviour
{
    public GameObject ghost;

    public Vector3[] startingLocations;

    public float timeDelay = 5f;
    private float timeCounter = 0.0f;
    private float numberOfGhostsSpawned = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter = Time.realtimeSinceStartup - numberOfGhostsSpawned * timeDelay;

        if (timeCounter >= timeDelay)
        {
            //Spawn ghost
            Instantiate(ghost, startingLocations[Random.Range(0, 5)], Quaternion.identity);


            numberOfGhostsSpawned++;
        }
    }
}
