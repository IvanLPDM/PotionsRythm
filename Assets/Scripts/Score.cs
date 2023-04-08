using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public float score;

    //ui scene
    public TextMeshProUGUI UiScore;
    public RectTransform RectTransform;
    public TextMeshProUGUI UiMultiplier;
    public TextMeshProUGUI UiScorenumber;
    public TextMeshProUGUI UiHighScore;

    public AudioSource audiosource;
    public AudioSource audiosource1;

    private Vector3 scaleChange;
    private Vector3 originalScale;
    private float RotationChange;

    //feedback color
    public Volume ppVolume;
    private Bloom bloom;

    public Light2D light;
    public bool miss;

    public Color InitialColor;
    public Color colorx2;
    public Color colorx3;
    public Color colorx4;
    public Color colorx5;

    //datos score y multiplicador
    public float multiplicador;
    public float goodTouchs;
    private float scoreWin;
    private string scoretext;
    private string multipliertext;

    //sliders
    public healthBar healthBar;
    public multiplierBar multiplierbar;

    void Start()
    {
        ppVolume.profile.TryGet<Bloom>(out bloom);

        multiplicador = 1;
        score = 0.0f;

        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 2:
                PlayerPrefs.GetFloat("HighScoreLevel1", 0).ToString();
                UiHighScore.text = PlayerPrefs.GetFloat("HighScoreLevel1", 0).ToString();
                break;
            case 3:
                PlayerPrefs.GetFloat("HighScoreLevel2", 0).ToString();
                UiHighScore.text = PlayerPrefs.GetFloat("HighScoreLevel2", 0).ToString();
                break;
            case 4:
                PlayerPrefs.GetFloat("HighScoreLevel3", 0).ToString();
                UiHighScore.text = PlayerPrefs.GetFloat("HighScoreLevel3", 0).ToString();
                break;
            case 5:
                PlayerPrefs.GetFloat("HighScoreLevel4", 0).ToString();
                UiHighScore.text = PlayerPrefs.GetFloat("HighScoreLevel4", 0).ToString();
                break;
            case 6:
                PlayerPrefs.GetFloat("HighScoreLevel5", 0).ToString();
                UiHighScore.text = PlayerPrefs.GetFloat("HighScoreLevel5", 0).ToString();
                break;
            case 7:
                PlayerPrefs.GetFloat("HighScoreLevel6", 0).ToString();
                UiHighScore.text = PlayerPrefs.GetFloat("HighScoreLevel6", 0).ToString();
                break;
        }
        

        UiScore.enabled = false;
        UiMultiplier.enabled = false;

        originalScale = new Vector3(0.75f, 0.75f, 0.75f);

        RotationChange = 0;

        RectTransform.localScale = originalScale;

        scaleChange = new Vector3(1f, 1f, 1f);

        miss = false;
    }

    // Update is called once per frame
    void Update()
    {
        UiMultiplier.text = multipliertext;

        if (goodTouchs >= 80)
        {
            multiplicador = 5;

            var tint = bloom.tint;
            tint.value = colorx5;
            bloom.tint = tint;

            UiMultiplier.enabled = true;
            multipliertext = "x5";
        }
        else if (goodTouchs >= 60)
        {
            multiplicador = 4;

            var tint = bloom.tint;
            tint.value = colorx4;
            bloom.tint = tint;

            UiMultiplier.enabled = true;
            multipliertext = "x4";
        }
        else if (goodTouchs >= 40)
        {
            multiplicador = 3;

            var tint = bloom.tint;
            tint.value = colorx3;
            bloom.tint = tint;

            UiMultiplier.enabled = true;
            multipliertext = "x3";

        }
        else if (goodTouchs >= 20)
        {
            multiplicador = 2;

            var tint = bloom.tint;
            tint.value = colorx2;
            bloom.tint = tint;

            UiMultiplier.enabled = true;
            multipliertext = "x2";

        }
        else
        {
            multiplicador = 1;

            var tint = bloom.tint;
            tint.value = InitialColor;
            bloom.tint = tint;

            UiMultiplier.enabled = true;
            multipliertext = " ";
        }

        //scale
        UiScore.text = scoretext;
        RectTransform.localScale += scaleChange * Time.deltaTime;

        if (RectTransform.localScale.y > 1f)
        {
            RectTransform.localScale = new Vector3(1f, 1f, 1f);
        }

        //highscore

        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 2:
                if (score > PlayerPrefs.GetFloat("HighScoreLevel1", 0))
                {
                    PlayerPrefs.SetFloat("HighScoreLevel1", score);
                    UiHighScore.text = score.ToString();
                }
                break;
            case 3:
                if (score > PlayerPrefs.GetFloat("HighScoreLevel2", 0))
                {
                    PlayerPrefs.SetFloat("HighScoreLevel2", score);
                    UiHighScore.text = score.ToString();
                }
                break;
            case 4:
                if (score > PlayerPrefs.GetFloat("HighScoreLevel3", 0))
                {
                    PlayerPrefs.SetFloat("HighScoreLevel3", score);
                    UiHighScore.text = score.ToString();
                }
                break;
            case 5:
                if (score > PlayerPrefs.GetFloat("HighScoreLevel4", 0))
                {
                    PlayerPrefs.SetFloat("HighScoreLevel4", score);
                    UiHighScore.text = score.ToString();
                }
                break;
            case 6:
                if (score > PlayerPrefs.GetFloat("HighScoreLevel5", 0))
                {
                    PlayerPrefs.SetFloat("HighScoreLevel5", score);
                    UiHighScore.text = score.ToString();
                }
                break;
            case 7:
                if (score > PlayerPrefs.GetFloat("HighScoreLevel6", 0))
                {
                    PlayerPrefs.SetFloat("HighScoreLevel6", score);
                    UiHighScore.text = score.ToString();
                }
                break;
        }
        
    }

    public void BadTouch()
    {
        goodTouchs = 0;

        scoreWin = 0;

        scoretext = "Miss";

        RectTransform.localScale = originalScale;

        audiosource.Play();

        miss = true;

        healthBar.currentHealth -= healthBar.levelMiss;
        multiplierbar.takeDamage();
    }
    
    public void NiceTouch()
    {

        scoreWin = 0;
        scoreWin += 10 * multiplicador;

        UiScore.enabled = true;

        score += 10 * multiplicador;
        UiScorenumber.text = score.ToString();

        goodTouchs++;

        scoretext = "Good";

        RectTransform.localScale = originalScale;

        audiosource1.Play();

        miss = false;

        healthBar.currentHealth += healthBar.levelHealing;
        multiplierbar.currentHealth += multiplierbar.levelHealing;
    }

    public void PerfectTouch()
    {
        scoreWin = 0;
        scoreWin += 25 * multiplicador;

        UiScore.enabled = true;

        score += 25 * multiplicador;
        UiScorenumber.text = score.ToString();

        goodTouchs++;

        scoretext = "Perfect";

        RectTransform.localScale = originalScale;

        audiosource1.Play();

        miss = false;

        healthBar.currentHealth += healthBar.levelHealing;
        multiplierbar.currentHealth += multiplierbar.levelHealing;
    }

    public void TextLeft()
    {
        UiScore.transform.position = new Vector3(17, -504, 0);
    }

    public void TextRight()
    {
        UiScore.transform.position = new Vector3(446, -504, 0);
    }
}
