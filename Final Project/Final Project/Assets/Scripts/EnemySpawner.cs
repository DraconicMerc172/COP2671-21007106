using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{

    public GameObject[] enemyPrefabs;

    private float spawnRangeZ = 20;

    private float spawnPosX;
    private float startDelay = 2;

    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) {

            SpawnRandomEnemy();

        }
    }

    void SpawnRandomEnemy() {

        int enemyIndex = UnityEngine.Random.Range(0, enemyPrefabs.Length);

        UnityEngine.Vector3 spawnPos = new UnityEngine.Vector3(spawnPosX, 0, UnityEngine.Random.Range(-spawnRangeZ, spawnRangeZ));

        Instantiate(enemyPrefabs[enemyIndex], spawnPos,
            enemyPrefabs[enemyIndex].transform.rotation);

    }
}
