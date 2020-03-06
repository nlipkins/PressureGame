using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private float spawnRangeX = 45;
    //private float spawnPosZ = 20;
    //private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        //playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnCar", 2, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCar()
    {
        int carIndex = Random.Range(0, obstaclePrefab.Length);
        Vector3 spawnPos = new Vector3(30, 0, 0);

        Instantiate(obstaclePrefab[carIndex], spawnPos, obstaclePrefab[carIndex].transform.rotation);
    }
}
