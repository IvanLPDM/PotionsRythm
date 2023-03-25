using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;

public class InputScript : MonoBehaviour
{
    public bool MantenidoLeft;
    public bool MantenidoRight;

    public float timePulsedL;
    public float totalTimeL;

    public GameObject Save;

    public float timePulsedR;
    public float totalTimeR;

    private Vector3 scalechange;
    Vector3 originalscale;

    public Transform transform;
    public Transform transform1;

    public Light2D light1L;
    public Light2D light2L;
    public Light2D light3L;
    public Light2D light4L;

    public Light2D light1R;
    public Light2D light2R;
    public Light2D light3R;
    public Light2D light4R;

    public Score scorecs;

    void Start()
    {
        timePulsedL = 0.0f;
        totalTimeL = 0.0f;

        MantenidoRight = false;
        MantenidoLeft = false;

        scalechange = new Vector3(0.01f, 0.01f, 0.01f);

        originalscale = new Vector3(0.75f, 0.75f, 0.75f);
        transform.localScale = originalscale;
        transform1.localScale = originalscale;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // creamos un touch y lo igualamos al primer toque de pantalla
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;


            if (touchPosition.x <= 0) //Left
            {
                GameObject.Find("GameManager").SendMessage("CheckCollisionLeft");
                //GameObject.Find("ScoreManager").SendMessage("TextLeft");
                //bola.transform.position = new Vector2(transform.position.x, 3);
            }
            else //Right
            {
                GameObject.Find("GameManager").SendMessage("CheckCollisionRight");
                //GameObject.Find("ScoreManager").SendMessage("TextRight");
                //bola.transform.position.y = 3;
            }

            //Teclado

        }

        if (transform.localScale.y > 1f)

        {

            transform.localScale = new Vector3(1f, 1f, 1f);

        }
        if (transform1.localScale.y > 1f)

        {

            transform1.localScale = new Vector3(1f, 1f, 1f);

        }

        //luces ventanas
        light1L.intensity -= 1.75f * Time.deltaTime;
        light2L.intensity -= 1.75f * Time.deltaTime;
        light3L.intensity -= 1.75f * Time.deltaTime;
        light4L.intensity -= 1.75f * Time.deltaTime;



        light1R.intensity -= 1.75f * Time.deltaTime;
        light2R.intensity -= 1.75f * Time.deltaTime;
        light3R.intensity -= 1.75f * Time.deltaTime;
        light4R.intensity -= 1.75f * Time.deltaTime;

        if (light1L.intensity <= 0f && light2L.intensity <= 0f && light3L.intensity <= 0f && light4L.intensity <= 0f)

        {

            light1L.intensity = 0f;

            light2L.intensity = 0f;

            light3L.intensity = 0f;

            light4L.intensity = 0f;

        }

        if (light1R.intensity <= 0f && light2R.intensity <= 0f && light3R.intensity <= 0f && light4R.intensity <= 0f)

        {

            light1R.intensity = 0f;

            light2R.intensity = 0f;

            light3R.intensity = 0f;

            light4R.intensity = 0f;

        }

        if (light1L.intensity < 0.4 && light2L.intensity < 0.4f && light3L.intensity < 0.4f && light4L.intensity < 0.4f && scorecs.miss == false)

        {

            light1L.intensity += 1.75f * Time.deltaTime;

            light2L.intensity += 1.75f * Time.deltaTime;

            light3L.intensity += 1.75f * Time.deltaTime;

            light4L.intensity += 1.75f * Time.deltaTime;

        }

        if (light1R.intensity < 0.4 && light2R.intensity < 0.4f && light3R.intensity < 0.4f && light4R.intensity < 0.4f && scorecs.miss == false)

        {

            light1R.intensity += 1.75f * Time.deltaTime;

            light2R.intensity += 1.75f * Time.deltaTime;

            light3R.intensity += 1.75f * Time.deltaTime;

            light4R.intensity += 1.75f * Time.deltaTime;

        }

        if (!Save.activeInHierarchy)
        {

            transform.localScale += scalechange;
            transform1.localScale += scalechange;
            //Pulsaci�n normal Left
            if (Input.GetKeyDown(KeyCode.A)) //Left
            {
                GameObject.Find("GameManager").SendMessage("CheckCollisionLeft");

                transform.localScale = originalscale;

                if (scorecs.miss == false)

                {

                    light1L.intensity = 0.9f;

                    light2L.intensity = 0.9f;

                    light3L.intensity = 0.9f;

                    light4L.intensity = 0.9f;

                }
            }


            if (Input.GetKeyDown(KeyCode.D)) //Right
            {
                GameObject.Find("GameManager").SendMessage("CheckCollisionRight");

                transform1.localScale = originalscale;

                if (scorecs.miss == false)

                {

                    light1R.intensity = 0.9f;

                    light2R.intensity = 0.9f;

                    light3R.intensity = 0.9f;

                    light4R.intensity = 0.9f;

                }
            }

            if (MantenidoRight == true)
            {
                //Mantenida Right
                if (Input.GetKey(KeyCode.D)) //Right
                {
                    //Empezar a contar
                    timePulsedR += 1 * Time.deltaTime;
                    GameObject.Find("CreadorPociones").SendMessage("LargeAntenaR");
                }
                if (Input.GetKeyUp(KeyCode.D)) //Right
                {
                    //Dejar de contar

                    if (timePulsedR >= 0.15f)
                    {
                        MantenidoRight = false;
                        totalTimeR = timePulsedR;
                        //Llamar funcion de mantenida
                        GameObject.Find("GameManager").SendMessage("CheckCollisionMantRight", totalTimeR);
                    }

                    timePulsedR = 0.0f;
                    totalTimeR = 0.0f;
                }
            }

            if (MantenidoLeft == true)
            {
                //Mantenida Left
                if (Input.GetKey(KeyCode.A)) //Left
                {
                    //Empezar a contar
                    timePulsedL += 1 * Time.deltaTime;
                    GameObject.Find("CreadorPociones").SendMessage("LargeAntenaL");
                }
                if (Input.GetKeyUp(KeyCode.A)) //Left
                {
                    //Dejar de contar
                    if (timePulsedL >= 0.15f)
                    {
                        MantenidoLeft = false;
                        totalTimeL = timePulsedL;
                        //Llamar funcion de mantenida
                        GameObject.Find("GameManager").SendMessage("CheckCollisionMantLeft", totalTimeL);
                    }

                    timePulsedL = 0.0f;
                    totalTimeL = 0.0f;
                }
            }
        }
    }

    public void FMantenidoLeft()
    {
        MantenidoLeft = true;
    }

    public void FMantenidoRight()
    {
        MantenidoRight = true;
    }

}