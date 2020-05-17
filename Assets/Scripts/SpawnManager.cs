using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] barrelPrefab;
    public GameObject[] carPrefab;
    //public GameObject[] militaryPrefab;

    private PlayerController playerControllerScript;

    private Vector3 spawnPosition;

    private float spawnPosZ1 = 4.15f;
    private float spawnPosZ2 = 0.8f;
    private float spawnPosX = 40;

    //[SerializeField] private float firstSpawn1;
    [SerializeField] private float spawnTime1;

    //[SerializeField] private float firstSpawn2;
    [SerializeField] private float spawnTime2;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBarrels", 1f, spawnTime1);

        InvokeRepeating("SpawnVehicles", 3f, spawnTime2);

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

}
