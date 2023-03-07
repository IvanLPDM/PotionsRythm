using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
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

        if (Input.GetKeyDown(KeyCode.A)) //Left
        {
            GameObject.Find("GameManager").SendMessage("CheckCollisionLeft");
            //bola.transform.position = new Vector2(transform.position.x, 3);
        }
        else if (Input.GetKeyDown(KeyCode.D)) //Right
        {
            GameObject.Find("GameManager").SendMessage("CheckCollisionRight");
            //bola.transform.position.y = 3;
        }
    }
}
