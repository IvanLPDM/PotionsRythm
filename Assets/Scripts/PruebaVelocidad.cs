using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaVelocidad : MonoBehaviour
{
    public float timeStart;

    // Start is called before the first frame update
    void Start()
    {
        timeStart = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += 1 * Time.deltaTime;

        if (transform.position.y <= -0.77f)
        {
            Debug.Log(timeStart);
        }
    }
}
