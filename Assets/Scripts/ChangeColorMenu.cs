using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;

public class ChangeColorMenu : MonoBehaviour
{

    public Volume ppVolume;
    private Bloom bloom;
    private Color color;
    public float h;
    // Start is called before the first frame update
    void Start()
    {
        ppVolume.profile.TryGet<Bloom>(out bloom);

        color = new Color(0.5f, 0.7f, 0.1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
 
        h += 0.05f * Time.deltaTime;

        if (h >= 1)
        {
            h = 0;
        }

        color = Color.HSVToRGB(h, 1, 1);

        var tint = bloom.tint;
        tint.value = color;
        bloom.tint = tint;
    }
}
