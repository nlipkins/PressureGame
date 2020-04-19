using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] barrelPrefab;
    public GameObject[] carPrefab;
    public GameObject[] militaryPrefab;

    private PlayerController playerControllerScript;

    private Vector3 spawnPosition;

    private float spawnPosZ1 = 4.15f;
    private float spawnPosZ2 = 0.8f;
    private float spawnPosX = 26;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBarrels", 2, 2.7f);

        InvokeRepeating("SpawnVehicles", 10.5f, 9.5f);

        InvokeRepeating("SpawnMilitary", 35, 11.275f);

        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBarrels()
    {
        int obstacleIndex = Random.Range(0, barrelPrefab.Length);
        spawnPosition = new Vector3(spawnPosX, 0, Random.Range(-spawnPosZ1, spawnPosZ2));

        if (playerControllerScript.gameOver == false)
        {
            Instantiate(barrelPrefab[obstacleIndex], spawnPosition, barrelPrefab[obstacleIndex].transform.rotation);
        }
    }

    void SpawnVehicles()
    {
        int carIndex = Random.Range(0, carPrefab.Length);
        spawnPosition = new Vector3(spawnPosX, 0, Random.Range(-spawnPosZ1, spawnPosZ2));

        if (playerControllerScript.gameOver == false)
        {
            Instantiate(carPrefab[carIndex], spawnPosition, carPrefab[carIndex].transform.rotation);
        }
    }

    void SpawnMilitary()
    {
        int militaryIndex = Random.Range(0, militaryPrefab.Length);
        spawnPosition = new Vector3(spawnPosX, 0, Random.Range(-spawnPosZ1, spawnPosZ2));

        if (playerControllerScript.gameOver == false)
        {
            Instantiate(militaryPrefab[militaryIndex], spawnPosition, militaryPrefab[militaryIndex].transform.rotation);
        }
    }
}
