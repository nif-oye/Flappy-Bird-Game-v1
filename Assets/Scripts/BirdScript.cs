using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    void Start()
    {
        gameObject.name = "Nifemi's Bird";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
            birdRigidbody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        birdIsAlive = false;
    }
}
