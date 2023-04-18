using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dobble : MonoBehaviour
{
    public float velocity;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos.x = 0.0f;
        pos.y = 3.8f;
    }

    // Update is called once per frame
    void Update()
    {
        pos.y -= velocity * Time.deltaTime;
        transform.position = pos;

        if (transform.position.y < -3.5)
        {
            Destroy(gameObject);
        }
    }
}
