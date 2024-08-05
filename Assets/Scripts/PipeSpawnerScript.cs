using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate){
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        float randomYPoint = Random.Range(lowestPoint, highestPoint);
        UnityEngine.Vector3 spawnPosition = new(transform.position.x, randomYPoint, transform.position.z);
        Instantiate(pipe, spawnPosition, transform.rotation);
    }
}
