using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class multiplierBar : MonoBehaviour
{

    public Slider slider;
    public Score score;
    public float maxHealth = 100;
    public float currentHealth;
    public float levelHealing;
    public float levelMiss;

    float lastNoteState;

    private void Start()
    {
        currentHealth = 0;
        setMaxHealth(maxHealth,currentHealth);
    }
    private void Update()
    {
        setHealth(currentHealth);

        if(currentHealth == 100 && score.goodTouchs < 80)
        {
            currentHealth = 0;
        }

    }

    public void setMaxHealth(float health, float current)
    {
        slider.maxValue = health;
        slider.value = current;
    }

    public void setHealth(float health)
    {
        slider.value = health;
    }

    public void takeDamage()
    {
        currentHealth = 0;

        setHealth(currentHealth);
    }
}
