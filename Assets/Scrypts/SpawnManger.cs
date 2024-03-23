using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{

    public GameObject[] animalPrefab;
    public float spawnRangeX = 20f;
    public float spawnRangeZ = 20f;

    private float time;
    private float startDelay = 20f;
    private float intervalOfWorking = 20f;

    // Start is called before the first frame update
    void Start()
    {
      

        InvokeRepeating("spawnRandomAnimals", startDelay, intervalOfWorking);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnRandomAnimals()
    {
        int animalKey = Random.Range(0, animalPrefab.Length);

        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, -spawnRangeX), 0, spawnRangeZ);

        Instantiate(animalPrefab[animalKey], spawnPos, animalPrefab[animalKey].transform.rotation);

        

    }
}

