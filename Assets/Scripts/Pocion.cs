using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocion : MonoBehaviour
{
    // Update is called once per frame
    public float velocity;
    public float startVelocity;
    public Vector3 pos;

    public TutorialManager tutorialManager;

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

        velocity = startVelocity;
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

            if (transform.position.x == 0.77f)
            {
                GameObject.Find("CreadorPociones").SendMessage("DeleteInfo", 1);
            }
            else if (transform.position.x == -0.77f)
            {
                GameObject.Find("CreadorPociones").SendMessage("DeleteInfo", 2);
            }

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

    public void PausarTutorial()
    {
         velocity = 0f;
         Debug.Log("pausado");
    }

    public void ReanudarTutorial()
    {
        velocity = 4f;
        Debug.Log("pausado");
    }
}
