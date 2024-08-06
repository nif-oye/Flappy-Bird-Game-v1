using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    private AudioSource gameOverSound;
    private int soundPlayCount = 0;

    void Start()
    {
        gameOverSound = GetComponent<AudioSource>();
    }

    [ContextMenu("Score Increase")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        soundPlayCount += 1;
        if (soundPlayCount == 1){
            gameOverSound.Play();
        }
    }
}
