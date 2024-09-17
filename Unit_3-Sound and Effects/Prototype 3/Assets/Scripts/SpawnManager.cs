using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;

    private UnityEngine.Vector3 spawnPos = new UnityEngine.Vector3(25, 0, 0);

    private float startDelay = 2;

    private float repeatRate = 2;

    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);

        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle() {

        if (playerControllerScript.gameOver == false) {

            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

        }

    }
}
