using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 2f;
    private float repeatRate = 3f;
    
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3 (15f, 1f, -1f);
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        
        // Repeates spawning of obstacle
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        // Once game over stops creating obstacles
        if (playerControllerScript.gameOver == false)
        {
            // Spawns obstacle 
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
