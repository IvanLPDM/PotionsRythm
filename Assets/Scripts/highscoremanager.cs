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
    public TextMeshProUGUI highscore10;
    public TextMeshProUGUI highscore11;
    public TextMeshProUGUI highscore12;
    public TextMeshProUGUI highscore13;
    public TextMeshProUGUI highscore14;
    public TextMeshProUGUI highscore15;
    public TextMeshProUGUI highscore16;

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
        highscore1.text = PlayerPrefs.GetFloat("HighScoreLevel7").ToString();
        highscore2.text = PlayerPrefs.GetFloat("HighScoreLevel8").ToString();
        highscore3.text = PlayerPrefs.GetFloat("HighScoreLevel9").ToString();
        highscore4.text = PlayerPrefs.GetFloat("HighScoreLevel1").ToString();
        highscore5.text = PlayerPrefs.GetFloat("HighScoreLevel2").ToString();
        highscore6.text = PlayerPrefs.GetFloat("HighScoreLevel3").ToString();
        highscore7.text = PlayerPrefs.GetFloat("HighScoreLevel4").ToString();
        highscore8.text = PlayerPrefs.GetFloat("HighScoreLevel5").ToString();
        highscore9.text = PlayerPrefs.GetFloat("HighScoreLevel6").ToString();
        highscore10.text = PlayerPrefs.GetFloat("HighScoreLevel10").ToString();
        highscore11.text = PlayerPrefs.GetFloat("HighScoreLevel11").ToString();
        highscore12.text = PlayerPrefs.GetFloat("HighScoreLevel12").ToString();
        highscore13.text = PlayerPrefs.GetFloat("HighScoreLevel13").ToString();
        highscore14.text = PlayerPrefs.GetFloat("HighScoreLevel14").ToString();
        highscore15.text = PlayerPrefs.GetFloat("HighScoreLevel15").ToString();
        highscore16.text = PlayerPrefs.GetFloat("HighScoreLevel16").ToString();


        //level 1 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel7") > 8000) //3
        {
            images[0].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel7") > 5000 && PlayerPrefs.GetFloat("HighScoreLevel7") < 8000) //2
        {
            images[0].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel7") > 3000) //1
        {
            images[0].sprite = sprites[1];
        }

        //level 2 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel8") > 18000) //3
        {
            images[1].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel8") > 10000 && PlayerPrefs.GetFloat("HighScoreLevel8") < 18000) //2
        {
            images[1].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel8") > 6000) //1
        {
            images[1].sprite = sprites[1];
        }

        //level 3 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel9") > 9000) //3
        {
            images[2].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel9") > 6000 && PlayerPrefs.GetFloat("HighScoreLevel9") < 9000) //2
        {
            images[2].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel9") > 3000) //1
        {
            images[2].sprite = sprites[1];
        }

        //level 4 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel1") > 4000) //3
        {
            images[3].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel1") > 2000 && PlayerPrefs.GetFloat("HighScoreLevel1") < 4000) //2
        {
            images[3].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel1") > 1000) //1
        {
            images[3].sprite = sprites[1];
        }

        //level 5 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel2") > 40000) //3
        {
            images[4].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel2") > 25000 && PlayerPrefs.GetFloat("HighScoreLevel2") < 40000) //2
        {
            images[4].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel2") > 5000) //1
        {
            images[4].sprite = sprites[1];
        }

        //level 6 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel3") > 6000) //3
        {
            images[5].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel3") > 2000 && PlayerPrefs.GetFloat("HighScoreLevel3") < 6000) //2
        {
            images[5].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel3") > 1000) //1
        {
            images[5].sprite = sprites[1];
        }

        //level 7 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel4") > 10000) //3
        {
            images[6].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel4") > 6000 && PlayerPrefs.GetFloat("HighScoreLevel4") < 10000) //2
        {
            images[6].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel4") > 2000) //1
        {
            images[6].sprite = sprites[1];
        }

        //level 8 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel5") > 15000) //3
        {
            images[7].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel5") > 10000 && PlayerPrefs.GetFloat("HighScoreLevel5") < 15000) //2
        {
            images[7].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel5") > 5000) //1
        {
            images[7].sprite = sprites[1];
        }

        //level 9 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel6") > 15000) //3
        {
            images[8].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel6") > 10000 && PlayerPrefs.GetFloat("HighScoreLevel6") < 15000) //2
        {
            images[8].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel6") > 5000) //1
        {
            images[8].sprite = sprites[1];
        }

        //level 10 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel10") > 15000) //3
        {
            images[9].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel10") > 10000 && PlayerPrefs.GetFloat("HighScoreLevel10") < 15000) //2
        {
            images[9].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel10") > 5000) //1
        {
            images[9].sprite = sprites[1];
        }

        //level 11 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel11") > 15000) //3
        {
            images[10].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel11") > 10000 && PlayerPrefs.GetFloat("HighScoreLevel11") < 15000) //2
        {
            images[10].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel11") > 5000) //1
        {
            images[10].sprite = sprites[1];
        }

        //level 12 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel12") > 15000) //3
        {
            images[11].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel12") > 10000 && PlayerPrefs.GetFloat("HighScoreLevel12") < 15000) //2
        {
            images[11].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel12") > 5000) //1
        {
            images[11].sprite = sprites[1];
        }

        //level 13 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel13") > 15000) //3
        {
            images[11].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel13") > 10000 && PlayerPrefs.GetFloat("HighScoreLevel13") < 15000) //2
        {
            images[11].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel13") > 5000) //1
        {
            images[11].sprite = sprites[1];
        }

        //level 14 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel14") > 15000) //3
        {
            images[11].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel14") > 10000 && PlayerPrefs.GetFloat("HighScoreLevel14") < 15000) //2
        {
            images[11].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel14") > 5000) //1
        {
            images[11].sprite = sprites[1];
        }

        //level 15 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel15") > 15000) //3
        {
            images[11].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel15") > 10000 && PlayerPrefs.GetFloat("HighScoreLevel15") < 15000) //2
        {
            images[11].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel15") > 5000) //1
        {
            images[11].sprite = sprites[1];
        }

        //level 16 stars
        if (PlayerPrefs.GetFloat("HighScoreLevel16") > 15000) //3
        {
            images[11].sprite = sprites[3];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel16") > 10000 && PlayerPrefs.GetFloat("HighScoreLevel16") < 15000) //2
        {
            images[11].sprite = sprites[2];
        }

        else if (PlayerPrefs.GetFloat("HighScoreLevel16") > 5000) //1
        {
            images[11].sprite = sprites[1];
        }

    }
}
