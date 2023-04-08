using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;

public class levelScroll : MonoBehaviour
{

    public Transform transformjoint1;
    public Transform transformjoint2;
    private Vector3 original = new Vector3(2f, 1.6f, 0f);
    private Vector3 original2 = new Vector3(20f, 1.6f, 0f);

    //feedback color
    public Volume ppVolume;
    private Bloom bloom;

    public Light2D light;

    public Color japanese;
    public Color medieval;

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
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D) && world < 1)
        {
            original.x -= 15f;

            transformjoint1.position = original;

            original2.x -= 15f;

            transformjoint2.position = original2;

            var tint = bloom.tint;
            tint.value = medieval;
            bloom.tint = tint;

            world++;
        }

        if (Input.GetKeyDown(KeyCode.A) && world > 0)
        {
            original.x += 15f;

            transformjoint1.position = original;

            original2.x += 15f;

            transformjoint2.position = original2;

            var tint = bloom.tint;
            tint.value = japanese;
            bloom.tint = tint;

            world--;
        }
    }
}
