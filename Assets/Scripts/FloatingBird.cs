using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloatingBird : MonoBehaviour
{
    private float timer;
    public float floatAmplitude = 0.5f; 
    public float floatFrequency = 2.0f; 
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position; 
    }

    public void startGame(){
        SceneManager.LoadScene("GameScene");
    }

    void Update()
    {
        timer += Time.deltaTime;
        float newY = startPos.y + Mathf.Sin(timer * floatFrequency) * floatAmplitude;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}
