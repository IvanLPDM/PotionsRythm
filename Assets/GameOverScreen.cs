using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverScreen : MonoBehaviour
{

    public TextMeshProUGUI scoretext;
    public void setup(float score)
    {
        gameObject.SetActive(true);
        scoretext.text = score.ToString() + " points";
    }
}
