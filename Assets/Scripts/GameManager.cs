using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool tutorial;
    public GameOverScreen gameOverScreen;
    public PauseScreen pauseScreen;
    public levelCompleted levelCompleted;
    public TutorialManager tutorialManager;

    public healthBar health;
    public Score score;
    public Shake shake;
    public AudioSource audioSource;
    public AudioSource audioParte2Tutorial;

    bool unaVez = false;

    float delay = 0;

    public int nextscene;
    bool gameover = false;

    private void Start()
    {

        nextscene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    void Update()
    {

        if (pauseScreen.ispaused == false)
        {
            Time.timeScale = 1f;
        }
        else
            Time.timeScale = 0f;

        
        delay += Time.deltaTime;

        float delayCancion = 0;

        
        if(tutorialManager.startFinishSong == true && unaVez == false)
        {
            audioParte2Tutorial.Play();
            unaVez = true;
        }

        if (!audioSource.isPlaying && delay >= 5 && pauseScreen.ispaused == false && gameover == false)
        {
            if (nextscene > PlayerPrefs.GetInt("nivel"))
            {
                PlayerPrefs.SetInt("nivel", nextscene);
            }

            if(tutorial == true)
            {
                if (tutorialManager.FasesSong == 1)
                {
                    audioSource.Play();
                }


                if (!audioParte2Tutorial.isPlaying && delay >= 5 && pauseScreen.ispaused == false && gameover == false)
                {
                     if (tutorialManager.FasesSong == 3)
                    {
                        Win();
                    }
                }
                
            }
            else
                Win();

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
        gameover = true;

    }

    public void Win()
    {
        levelCompleted.setup(score.score);
        shake.StartShake(0f);
    }

    public void StopGame()
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
}
