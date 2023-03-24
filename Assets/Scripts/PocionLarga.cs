using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocionLarga : MonoBehaviour
{
    public GameObject rect;
    public float rectLarge;

    public float time;

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
        large = large * 6f;
        float distanciaLinea = (large + 0.8f) / 2;

        rect.transform.localScale = new Vector3(rect.transform.localScale.x, large, rect.transform.localScale.z);
        rect.transform.position = new Vector3(transform.position.x, transform.position.y + distanciaLinea / 2, 0);

        GlowRect.transform.localScale = new Vector3(GlowRect.transform.localScale.x, large, GlowRect.transform.localScale.z);
        GlowRect.transform.position = new Vector3(transform.position.x, transform.position.y + distanciaLinea / 2, 0);
    }

    public void Stay()
    {
        time = 4 * Time.deltaTime;

        transform.position = new Vector3(transform.position.x, -2.4f, transform.position.z);

        rect.transform.position = new Vector3(transform.position.x, rect.transform.position.y - time, 0);
        GlowRect.transform.position = new Vector3(transform.position.x, rect.transform.position.y - time, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
