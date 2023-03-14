using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterpolationWater : MonoBehaviour
{

    public Vector3 endPosition;
    private Vector3 startPosition;
    public float duration = 2f;
    private float elapsedtime;

    [SerializeField]
    private AnimationCurve curve;
    // Start is called before the first frame update 
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame 
    void Update()
    {
        elapsedtime += Time.deltaTime;
        float percentageComplete = elapsedtime / duration;

        transform.position = Vector3.Lerp(startPosition, endPosition, curve.Evaluate(percentageComplete));

        if (percentageComplete >= 1)
        {

            elapsedtime = 0;
            Vector3 aux = startPosition;
            startPosition = endPosition;
            endPosition = aux;

        }
    }
}
