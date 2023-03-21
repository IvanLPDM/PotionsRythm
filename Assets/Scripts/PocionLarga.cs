using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocionLarga : MonoBehaviour
{
    public GameObject rect;
    public float rectLarge;

    public GameObject GlowRect;

    // Start is called before the first frame update
    void Start()
    {
        //float distanciaLinea = (rectLarge + 0.8f)/2;

        //rect.transform.localScale = new Vector3 (rect.transform.localScale.x, rectLarge, rect.transform.localScale.z);
        //rect.transform.position = new Vector3(transform.position.x, transform.position.y + distanciaLinea / 2, 0);

        //GlowRect.transform.localScale = new Vector3(GlowRect.transform.localScale.x, rectLarge, GlowRect.transform.localScale.z);
        //GlowRect.transform.position = new Vector3(transform.position.x, transform.position.y + distanciaLinea / 2, 0);
    }

    public void ChangeLarge(float large)
    {
        large = large * 3;
        float distanciaLinea = (large + 0.8f) / 2;

        rect.transform.localScale = new Vector3(rect.transform.localScale.x, large, rect.transform.localScale.z);
        rect.transform.position = new Vector3(transform.position.x, transform.position.y + distanciaLinea / 2, 0);

        GlowRect.transform.localScale = new Vector3(GlowRect.transform.localScale.x, large, GlowRect.transform.localScale.z);
        GlowRect.transform.position = new Vector3(transform.position.x, transform.position.y + distanciaLinea / 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
