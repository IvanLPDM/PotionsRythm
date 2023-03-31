using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class highscoremanager : MonoBehaviour
{

    public TextMeshProUGUI highscore1;
    public TextMeshProUGUI highscore2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highscore1.text =  PlayerPrefs.GetFloat("HighScore").ToString();
        highscore2.text = PlayerPrefs.GetFloat("HighScore2").ToString();
    }
}
