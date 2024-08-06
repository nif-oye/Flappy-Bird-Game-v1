using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 7;

    void Start()
    {
        SpawnCloud();
    }
    void Update()
    {
        if (timer < spawnRate){
            timer += Time.deltaTime;
        }
        else
        {
            SpawnCloud();
            timer = 0;
        }
    }
    void SpawnCloud(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        float randomYPoint = Random.Range(lowestPoint, highestPoint);
        Vector3 spawnPosition = new(transform.position.x, randomYPoint, transform.position.z);
        Instantiate(cloud, spawnPosition, transform.rotation);
    }
}
