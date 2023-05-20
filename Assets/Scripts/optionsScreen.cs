using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class optionsScreen : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void setup()
    {
        gameObject.SetActive(true);
    }

    public void setVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void goBack()
    {
        gameObject.SetActive(false);
    }
}
