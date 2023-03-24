using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    public bool MantenidoLeft;
    public bool MantenidoRight;

    public float timePulsedL;
    public float totalTimeL;

    public GameObject Save;

    public float timePulsedR;
    public float totalTimeR;

    void Start()
    {
        timePulsedL = 0.0f;
        totalTimeL = 0.0f;

        MantenidoRight = false;
        MantenidoLeft = false;
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

        if (!Save.activeInHierarchy)
        {
            //Pulsación normal Left
            if (Input.GetKeyDown(KeyCode.A)) //Left
            {
                GameObject.Find("GameManager").SendMessage("CheckCollisionLeft");
            }

            if (Input.GetKeyDown(KeyCode.D)) //Right
            {
                GameObject.Find("GameManager").SendMessage("CheckCollisionRight");
            }


            if (MantenidoRight == true)
            {
                //Mantenida Right
                if (Input.GetKey(KeyCode.D)) //Right
                {
                    //Empezar a contar
                    GameObject.Find("CreadorPociones").SendMessage("LargeAntenaR");
                    timePulsedR += 1 * Time.deltaTime;
                }
                if (Input.GetKeyUp(KeyCode.D)) //Right
                {
                    //Dejar de contar
                    totalTimeR = timePulsedR;

                    if (totalTimeR >= 1.0f)
                    {
                        MantenidoRight = false;
                        totalTimeR = timePulsedR;
                        //Llamar funcion de mantenida
                        GameObject.Find("GameManager").SendMessage("CheckCollisionMantRight", totalTimeR);
                    }

                    timePulsedR = 0.0f;
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