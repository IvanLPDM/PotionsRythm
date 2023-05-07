using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;

public class levelScroll : MonoBehaviour
{

    public Transform transformjoint1;
    public Transform transformjoint2;
    public Transform transformjoint3;
    private Vector3 original = new Vector3(2f, 1.6f, 0f);
    private Vector3 original2 = new Vector3(20f, 1.6f, 0f);
    private Vector3 original3 = new Vector3(38f, 1.6f, 0f);

    //feedback color
    public Volume ppVolume;
    private Bloom bloom;

    public Light2D light;

    public Color japanese;
    public Color medieval;
    public Color Phonk;

    public GameObject dbutton;
    public GameObject abutton;

    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;

    int world = 0;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        ppVolume.profile.TryGet<Bloom>(out bloom);

        var tint = bloom.tint;
        tint.value = japanese;
        bloom.tint = tint;

        transformjoint1.position = original;
        transformjoint2.position = original2;
        transformjoint3.position = original3;

        dbutton.SetActive(true);

        audioSource1.Play();
        audioSource2.Play();
        audioSource3.Play();
        audioSource2.Pause();
        audioSource3.Pause();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D) && world < 2)
        {
            original.x -= 15f;

            transformjoint1.position = original;

            original2.x -= 15f;

            transformjoint2.position = original2;

            original3.x -= 15f;

            transformjoint3.position = original3;

            world++;

            dbutton.SetActive(false);
            abutton.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.A) && world > 0)
        {
            original.x += 15f;

            transformjoint1.position = original;

            original2.x += 15f;

            transformjoint2.position = original2;

            original3.x += 15;

            transformjoint3.position = original3;

            world--;

            abutton.SetActive(false);
            dbutton.SetActive(true);
        }

        switch (world)
        {
            case 0:
                audioSource1.UnPause();
                audioSource2.Pause();
                audioSource3.Pause();

                var tint = bloom.tint;
                tint.value = Phonk;
                bloom.tint = tint;
                break;

            case 1:
                audioSource1.Pause();
                audioSource2.UnPause();
                audioSource3.Pause();

                var tint1 = bloom.tint;
                tint1.value = japanese;
                bloom.tint = tint1;
                break;

            case 2:
                audioSource1.Pause();
                audioSource2.Pause();
                audioSource3.UnPause();

                var tint2 = bloom.tint;
                tint2.value = medieval;
                bloom.tint = tint2;
                break;

                default:
                break;

        }
    }
}