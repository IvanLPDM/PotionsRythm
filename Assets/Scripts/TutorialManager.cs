using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public int fasesAnimacion = 0;
    public float time = 0;
    public bool paused = false;
    public GameObject wizard;


    // Start is called before the first frame update
    void Start()
    {
        wizard.SetActive(false);    
    }

    // Update is called once per frame
    void Update()
    {
        time += 1 * Time.deltaTime;

        Debug.Log(time);

        if (time >= 5.7 && paused == false)
        {
            paused = true;
            wizard.SetActive(true);
        }
    }
}
