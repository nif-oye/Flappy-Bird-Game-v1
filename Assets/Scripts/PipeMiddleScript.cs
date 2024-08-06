using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public BirdScript theBirdScript;
    private AudioSource dingSound;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        theBirdScript = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
        dingSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.layer == 3 && theBirdScript.birdIsAlive){
            logic.addScore(1);
            dingSound.Play();
        }
    }
}
