using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public AudioSource audioSource;

    public bool ispaused = false;
    public void setup()
    {
        gameObject.SetActive(true);
    }

    public void restartButton()
    {
        SceneManager.LoadScene("Level-4");
        Time.timeScale = 1f;
    }

    public void levelSelectorButton()
    {
        SceneManager.LoadScene("SelectorNiveles");
        Time.timeScale = 1f;
    }

    public void resumeButton()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1f;
        ispaused = false;
        audioSource.UnPause();
    }

    public void pause()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    }
}
