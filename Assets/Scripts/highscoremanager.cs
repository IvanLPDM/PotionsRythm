using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class highscoremanager : MonoBehaviour
{

    public TextMeshProUGUI highscore1;
    public TextMeshProUGUI highscore2;
    public TextMeshProUGUI highscore3;
    public TextMeshProUGUI highscore4;
    public TextMeshProUGUI highscore5;
    public TextMeshProUGUI highscore6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highscore1.text = PlayerPrefs.GetFloat("HighScoreLevel1").ToString();
        highscore2.text = PlayerPrefs.GetFloat("HighScoreLevel2").ToString();
        highscore3.text = PlayerPrefs.GetFloat("HighScoreLevel3").ToString();
        highscore4.text = PlayerPrefs.GetFloat("HighScoreLevel4").ToString();
        highscore5.text = PlayerPrefs.GetFloat("HighScoreLevel5").ToString();
        highscore6.text = PlayerPrefs.GetFloat("HighScoreLevel6").ToString();
    }
}
