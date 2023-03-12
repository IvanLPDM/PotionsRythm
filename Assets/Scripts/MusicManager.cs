using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Audio;
using UnityEngine.UIElements;

public class MusicManager : MonoBehaviour
{
    public AudioSource song;
    public float timeStart;

    public float songOffset;
    public float AdjustedSongTime { get { return song.time - songOffset; } }
    public static float BeatProximity { get; private set; }
    public int BPM;
    private float beatTime;
    public Transform test;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        song = GetComponent<AudioSource>();
        beatTime = 60f / (float)BPM;
        yield return new WaitForSeconds(timeStart);
        song.Play();

        //Acceder al beat proximity sin referencia
        //float b = MusicManager.BeatProximity;
    }

    // Update is called once per frame
    void Update()
    {
        //beatproximity: closer to 0 = closer to beat;
        //beatproximity: closer to 1 = further from beat;
        BeatProximity = Mathf.Sqrt(Mathf.Abs(Mathf.Sin(Mathf.Deg2Rad * (90f + 180f * (AdjustedSongTime / beatTime)))));
        test.transform.localScale = Vector3.one * BeatProximity;
    }
}
