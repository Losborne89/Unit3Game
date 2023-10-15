using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 2f;
    private float repeatRate = 2f;
    
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3 (10f, 1f, -1f);

    // Start is called before the first frame update
    void Start()
    {
        // Repeates spawning of obstacle
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        // Spawns obstacle 
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
