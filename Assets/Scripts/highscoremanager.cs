using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class highscoremanager : MonoBehaviour
{

    public TextMeshProUGUI highscore1;
    public TextMeshProUGUI highscore2;
    public TextMeshProUGUI highscore3;
    public TextMeshProUGUI highscore4;
    public TextMeshProUGUI highscore5;
    public TextMeshProUGUI highscore6;
    public TextMeshProUGUI highscore7;
    public TextMeshProUGUI highscore8;
    public TextMeshProUGUI highscore9;

    public Image[] images;

    public Sprite[] sprites;

    public
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < images.Length; i++)
        {
            images[i].sprite = sprites[0];
        }
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
        highscore7.text = PlayerPrefs.GetFloat("HighScoreLevel7").ToString();
        highscore8.text = PlayerPrefs.GetFloat("HighScoreLevel8").ToString();
        highscore9.text = PlayerPrefs.GetFloat("HighScoreLevel9").ToString();


        //level 1 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel1") > 3500) //3
        {
            images[0].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel1") > 2000 && PlayerPrefs.GetFloat("HighScoreLevel1") < 3500) //2
        {
            images[0].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel1") > 1000) //1
        {
            images[0].sprite = sprites[1];
        }

        //level 2 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel2") > 40000) //3
        {
            images[1].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel2") > 25000 && PlayerPrefs.GetFloat("HighScoreLevel2") < 40000) //2
        {
            images[1].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel2") > 10000) //1
        {
            images[1].sprite = sprites[1];
        }

        //level 3 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel3") > 9000) //3
        {
            images[2].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel3") > 6000 && PlayerPrefs.GetFloat("HighScoreLevel3") < 9000) //2
        {
            images[2].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel3") > 3000) //1
        {
            images[2].sprite = sprites[1];
        }

        //level 4 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel4") > 10000) //3
        {
            images[3].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel4") > 7000 && PlayerPrefs.GetFloat("HighScoreLevel4") < 10000) //2
        {
            images[3].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel4") > 4000) //1
        {
            images[3].sprite = sprites[1];
        }

        //level 5 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel5") > 15000) //3
        {
            images[4].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel5") > 10000 && PlayerPrefs.GetFloat("HighScoreLevel5") < 15000) //2
        {
            images[4].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel5") > 5000) //1
        {
            images[4].sprite = sprites[1];
        }

        //level 6 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel6") > 15000) //3
        {
            images[5].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel6") > 10000 && PlayerPrefs.GetFloat("HighScoreLevel6") < 15000) //2
        {
            images[5].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel6") > 5000) //1
        {
            images[5].sprite = sprites[1];
        }

        //level 7 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel7") > 15000) //3
        {
            images[5].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel7") > 10000 && PlayerPrefs.GetFloat("HighScoreLevel7") < 15000) //2
        {
            images[5].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel7") > 5000) //1
        {
            images[5].sprite = sprites[1];
        }

        //level 8 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel8") > 15000) //3
        {
            images[5].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel8") > 10000 && PlayerPrefs.GetFloat("HighScoreLevel8") < 15000) //2
        {
            images[5].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel8") > 5000) //1
        {
            images[5].sprite = sprites[1];
        }

        //level 9 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel9") > 15000) //3
        {
            images[5].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel9") > 10000 && PlayerPrefs.GetFloat("HighScoreLevel9") < 15000) //2
        {
            images[5].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel9") > 5000) //1
        {
            images[5].sprite = sprites[1];
        }

    }
}
