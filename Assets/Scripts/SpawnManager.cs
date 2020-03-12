using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] barrelPrefab;
    public GameObject[] carPrefab;
    public GameObject[] militaryPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBarrels", 2, 2.5f);

        InvokeRepeating("SpawnVehicles", 9.5f, 7f);

        InvokeRepeating("SpawnMilitary", 30, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBarrels()
    {
        int obstacleIndex = Random.Range(0, barrelPrefab.Length);
        Vector3 spawnPos = new Vector3(30, 0, 0);

        Instantiate(barrelPrefab[obstacleIndex], spawnPos, barrelPrefab[obstacleIndex].transform.rotation);
    }

    void SpawnVehicles()
    {
        int carIndex = Random.Range(0, carPrefab.Length);
        Vector3 spawnPos2 = new Vector3(30, 0, 0);

        Instantiate(carPrefab[carIndex], spawnPos2, carPrefab[carIndex].transform.rotation);
    }

    void SpawnMilitary()
    {
        int militaryIndex = Random.Range(0, militaryPrefab.Length);
        Vector3 spawnPos3 = new Vector3(30, 0, 0);

        Instantiate(militaryPrefab[militaryIndex], spawnPos3, militaryPrefab[militaryIndex].transform.rotation);
    }
}
