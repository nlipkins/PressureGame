using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] barrelPrefab;
    public GameObject[] carPrefab;
    public GameObject[] militaryPrefab;

    private PlayerController playerControllerScript;

    public Vector3 spawnPosition;
    public Vector3 spawnPosition2;
    public Vector3 spawnPosition3;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBarrels", 2, 2.25f);

        InvokeRepeating("SpawnVehicles", 9.5f, 9.3f);

        InvokeRepeating("SpawnMilitary", 30, 8.25f);

        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBarrels()
    {
        int obstacleIndex = Random.Range(0, barrelPrefab.Length);
        spawnPosition = new Vector3(30, 0, -1.5f);

        if (playerControllerScript.gameOver == false)
        {
            Instantiate(barrelPrefab[obstacleIndex], spawnPosition, barrelPrefab[obstacleIndex].transform.rotation);
        }
    }

    void SpawnVehicles()
    {
        int carIndex = Random.Range(0, carPrefab.Length);
        spawnPosition2 = new Vector3(30, 0, -1.5f);

        if (playerControllerScript.gameOver == false)
        {
            Instantiate(carPrefab[carIndex], spawnPosition2, carPrefab[carIndex].transform.rotation);
        }
    }

    void SpawnMilitary()
    {
        int militaryIndex = Random.Range(0, militaryPrefab.Length);
        spawnPosition3 = new Vector3(30, 0, -1.5f);

        if (playerControllerScript.gameOver == false)
        {
            Instantiate(militaryPrefab[militaryIndex], spawnPosition3, militaryPrefab[militaryIndex].transform.rotation);
        }
    }
}
