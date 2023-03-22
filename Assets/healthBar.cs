using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{

    public Slider slider;
    public float maxHealth = 100;
    public float currentHealth;
    public float leveldamage;
    public float levelHealing;

    public PositionDetection positionDetection;
    float lastNoteState;

    private void Start()
    {
        currentHealth = maxHealth;
        setMaxHealth(maxHealth);
    }
    private void Update()
    {

        takeDamage(leveldamage);

        //if(positionDetection.checkHealthStateL == 1 || positionDetection.checkHealthStateL == 2 || positionDetection.checkHealthStateR == 1 || positionDetection.checkHealthStateR == 2)
        //{
        //    currentHealth += levelHealing;
        //}
        //if (positionDetection.checkHealthStateL == 3 || positionDetection.checkHealthStateR == 3)
        //{
        //    currentHealth -= levelHealing;
        //}

        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
        if(currentHealth <= 0)
        {
            currentHealth = 0;
        }
       
    }

    public void setMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void setHealth(float health)
    {
        slider.value = health;
    }

    void takeDamage(float damage)
    {
        currentHealth -= damage;

        setHealth(currentHealth);
    }
}
