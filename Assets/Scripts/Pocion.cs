using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocion : MonoBehaviour
{
    // Update is called once per frame
    public float velocity;
    public Vector3 pos;

    [Header("Color")]
    public SpriteRenderer renderero;
    public Color originalColor;
    public Color BadColor;
    public Color NiceColor;
    public Color PerfectColor;

    [Header("Logica de Input")]
    public float falloDelay;
    public float InitialFalloDelay;

    [Header("Guardado")]
    public int Direccion;

    public float timeToCreate;


    private float OriginColorTime;

    void Start()
    {
        renderero.color = originalColor;
        OriginColorTime = 0;
    }

    void Update()
    {
        if(OriginColorTime > 0)
            OriginColorTime -= 0.1f;

        pos = transform.position;
        pos.y -= velocity * Time.deltaTime;
        transform.position = pos;

       // Delete
        if (transform.position.y < -3.5)
        {
            GameObject.Find("ScoreManager").SendMessage("BadTouch");
            Camera.main.gameObject.GetComponent<Shake>().StartShake();
            Destroy(gameObject);
        }

        if (OriginColorTime <= 0)
        {
            renderero.color = originalColor;
        }

        //Actualizar delay
        if (falloDelay > 0)
        {
            falloDelay -= 0.1f;
        }
    }

    void Fallo()
    {
        if(falloDelay <= 0)
        {
            GameObject.Find("ScoreManager").SendMessage("BadTouch");

            falloDelay = InitialFalloDelay;
        }

        //renderero.color = BadColor;
        //OriginColorTime = delayColor;

        //sumar puntos
        //destruir
    }

    void Acierto()
    {
        if (falloDelay <= 0)
        {
            GameObject.Find("ScoreManager").SendMessage("NiceTouch");

            falloDelay = InitialFalloDelay;
        }

        //OriginColorTime = delayColor;
        //renderero.color = NiceColor;
    }

    void Perfect()
    {
        if (falloDelay <= 0)
        {
            GameObject.Find("ScoreManager").SendMessage("PerfectTouch");

            falloDelay = InitialFalloDelay;
        }

        //OriginColorTime = delayColor;
        //renderero.color = PerfectColor;
    }
}
