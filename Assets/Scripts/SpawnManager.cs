using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnVehicle", 2, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnVehicle()
    {
        int carIndex = Random.Range(0, obstaclePrefab.Length);
        Vector3 spawnPos = new Vector3(30, 0, 0);

        Instantiate(obstaclePrefab[carIndex], spawnPos, obstaclePrefab[carIndex].transform.rotation);
    }
}
