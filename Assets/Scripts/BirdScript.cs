using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidbody;
    public float flapStrength;
    void Start()
    {
        gameObject.name = "Nifemi's Bird"; 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true){
            birdRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
}
