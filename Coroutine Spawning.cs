using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoroutineSpawning : MonoBehaviour {

    public GameObject rock;
    public GameObject log;
    public GameObject blowPoint;
    public Transform[] spawnPoint;

    public GameObject tree_0;
    public GameObject tree_1;
    public Transform TreeSpawnPointLeft;
    public Transform TreeSpawnPointRight;

    float speedMultiplier = 1;
    public float baseForSpeedIncrease = 1.01f;
    public double timeBeforeSpeedUp = 5;
    float spawnTime;
    public float initialSpawnTime = 1f;
    float randomOffset;

    // Use this for initialization
    void Start()
    {
        spawnTime = initialSpawnTime;
        randomOffset = UnityEngine.Random.Range(0, spawnTime / 4);

        StartCoroutine(Spawn(initialSpawnTime));
        StartCoroutine(SpawnTreeLeft(initialSpawnTime));
        StartCoroutine(SpawnTreeRight(initialSpawnTime));
    }

    // Update is called once per frame

    IEnumerator Spawn(float spawnTime)
    {
        
        randomOffset = UnityEngine.Random.Range(0, spawnTime / 4);

        if (Time.timeSinceLevelLoad > timeBeforeSpeedUp)
        {
            spawnTime = (int)((Math.Pow(baseForSpeedIncrease, Time.timeSinceLevelLoad - timeBeforeSpeedUp)) + initialSpawnTime);

        }
        yield return new WaitForSeconds(spawnTime);



        int whichSpawn = UnityEngine.Random.Range(1, 20);

        if (whichSpawn <= 15)
        {
            int spawnPointIndex = UnityEngine.Random.Range(0, 5);

            Instantiate(rock, spawnPoint[spawnPointIndex].position, spawnPoint[spawnPointIndex].rotation);
        }

        else if (whichSpawn <= 19)
        {
            int spawnPointIndex = UnityEngine.Random.Range(0, 5);

            Instantiate(log, spawnPoint[spawnPointIndex].position, spawnPoint[spawnPointIndex].rotation);
        }

        else if (whichSpawn == 20)
        {
            int spawnPointIndex = UnityEngine.Random.Range(0, 5);

            Instantiate(blowPoint, spawnPoint[spawnPointIndex].position, spawnPoint[spawnPointIndex].rotation);
        }



    }

    IEnumerator SpawnTreeLeft(float spawnTime)
    {

        randomOffset = UnityEngine.Random.Range(0, spawnTime / 4);

        if (Time.timeSinceLevelLoad > timeBeforeSpeedUp)
        {
            spawnTime = (int)((Math.Pow(baseForSpeedIncrease, Time.timeSinceLevelLoad - timeBeforeSpeedUp)) + initialSpawnTime);

        }

        yield return new WaitForSeconds(spawnTime);

        int whichSpawn = UnityEngine.Random.Range(0, 2);

        if (whichSpawn == 0)
        {

            Instantiate(tree_0, TreeSpawnPointLeft.position, TreeSpawnPointLeft.rotation);
        }

        else if (whichSpawn == 1)
        {
            Instantiate(tree_1, TreeSpawnPointLeft.position, TreeSpawnPointLeft.rotation);
        }
    }

    IEnumerator SpawnTreeRight(float spawnTime)
    {

        randomOffset = UnityEngine.Random.Range(0, spawnTime / 4);

        if (Time.timeSinceLevelLoad > timeBeforeSpeedUp)
        {
            spawnTime = (int)((Math.Pow(baseForSpeedIncrease, Time.timeSinceLevelLoad - timeBeforeSpeedUp)) + initialSpawnTime);

        }

        yield return new WaitForSeconds(spawnTime);

        int whichSpawn = UnityEngine.Random.Range(0, 2);

        if (whichSpawn == 0)
        {

            Instantiate(tree_0, TreeSpawnPointRight.position, TreeSpawnPointRight.rotation);
        }

        else if (whichSpawn == 1)
        {
            Instantiate(tree_1, TreeSpawnPointRight.position, TreeSpawnPointRight.rotation);
        }
    }




    void Update()
    {


    }
}
