using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    public TextMeshProUGUI scoretext;
    public void setup(float score)
    {
        gameObject.SetActive(true);
        scoretext.text = score.ToString() + " points";
    }

    public void restartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void levelSelectorButton()
    {
        SceneManager.LoadScene("SelectorNiveles");
        Time.timeScale = 1f;
    }
}
