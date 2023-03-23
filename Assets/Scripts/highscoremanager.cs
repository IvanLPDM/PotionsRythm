using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class highscoremanager : MonoBehaviour
{

    public TextMeshProUGUI highscore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highscore.text =  PlayerPrefs.GetFloat("HighScore").ToString();
    }
}
