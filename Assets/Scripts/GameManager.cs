using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //GameOver
    public GameOverScreen gameOverScreen;
    public PauseScreen pauseScreen;

    public healthBar health;
    public Score score;
    public Shake shake;
    public AudioSource audioSource;

    void Update()
    {
        if(pauseScreen.ispaused == false)
        {
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseScreen.ispaused)
            {
                pauseScreen.resumeButton();
                audioSource.UnPause();
            }
            else
            {
                pauseScreen.pause();
                audioSource.Pause();
            }
        }
        
        if(health.currentHealth <= 0)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        gameOverScreen.setup(score.score);
        shake.StartShake(0f);
        audioSource.Pause();
        Time.timeScale = 0f;

    }
}
