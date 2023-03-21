using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    public float timePulsedL;
    public float totalTimeL;

    public float timePulsedR;
    public float totalTimeR;

    void Start()
    {
        timePulsedL = 0.0f;
        totalTimeL = 0.0f;
    }

    void Update()
    {
        if(Input.touchCount > 0)
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

        //Pulsación normal Left
        if (Input.GetKeyDown(KeyCode.A)) //Left
        {
            GameObject.Find("GameManager").SendMessage("CheckCollisionLeft");
        }

        //Mantenida Left
        if (Input.GetKey(KeyCode.A)) //Left
        {
            //Empezar a contar
            timePulsedL += 1 * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.A)) //Left
        {
            //Dejar de contar
            

            if(timePulsedL >= 0.15f)
            {
                totalTimeL = timePulsedL;
                //Llamar funcion de mantenida
                GameObject.Find("GameManager").SendMessage("CheckCollisionMantLeft");
            }                

            timePulsedL = 0.0f;
        }


        if (Input.GetKeyDown(KeyCode.D)) //Right
        {
            GameObject.Find("GameManager").SendMessage("CheckCollisionRight");
        }

        //Mantenida Right
        if (Input.GetKey(KeyCode.D)) //Right
        {
            //Empezar a contar
            timePulsedR += 1 * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.D)) //Right
        {
            //Dejar de contar
            totalTimeR = timePulsedR;

            if (totalTimeR >= 1.0f)
            {
                //Llamar funcion de mantenida

            }

            timePulsedR = 0.0f;
        }


    }
}
