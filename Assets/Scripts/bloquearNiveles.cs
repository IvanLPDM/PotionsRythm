using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bloquearNiveles : MonoBehaviour
{

    public Button[] buttons;
    void Start()
    {
        int nivel = PlayerPrefs.GetInt("nivel", 2);

        for(int i = 0; i < buttons.Length; i++)
        {
            if(i + 2 > nivel)
            {
                buttons[i].interactable = false;
            }
        }
    }
}
