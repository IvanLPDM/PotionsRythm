using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MusicNameScreen : MonoBehaviour
{
    public TextMeshProUGUI nameTrack;

    float color;

    private void Start()
    {
        color = nameTrack.color.a;
    }
    private void Update()
    {
        color -= 0.25f * Time.deltaTime;

        nameTrack.color = new Color(255, 255, 255, color);

        if(nameTrack.color.a <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
