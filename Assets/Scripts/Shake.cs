using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public AnimationCurve curve;
    private float lastShakeTime;
    private float shakeDuration;
    Vector3 startPosition;
    private void Start()
    {
        Vector3 startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float elapsed = (Time.time - lastShakeTime) / shakeDuration;
        if (elapsed <= 1f)
        {
            float strength = curve.Evaluate(elapsed);
            transform.position = startPosition + Random.insideUnitSphere * strength + Vector3.back *10f ;
        }
        else
        {
            transform.position = startPosition + Vector3.back * 10f;
        }
    }
    public void StartShake(float duration = 0.2f)
    {
        shakeDuration = duration;
        lastShakeTime = Time.time;
    }
}
