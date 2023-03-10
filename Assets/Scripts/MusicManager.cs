using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Audio;

public class MusicManager : MonoBehaviour
{
    public AudioSource Song;
    public float timeStart;

    // Start is called before the first frame update
    void Start()
    {
        Song = GetComponent<AudioSource>();
        Song.mute = true;
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += 1 * Time.deltaTime;

        if (timeStart <= 4)
        {
            Song.mute = false;
            Song.Play();
        }
            
    }
}
