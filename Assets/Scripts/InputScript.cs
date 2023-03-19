using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{

    private Vector3 scalechange;
    Vector3 originalscale;

    public Transform transform;
    public Transform transform1;

    private void Start()
    {
        scalechange = new Vector3(0.01f, 0.01f, 0.01f);

        originalscale = new Vector3(0.75f, 0.75f, 0.75f);
        transform.localScale = originalscale;
        transform1.localScale = originalscale;
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

        transform.localScale += scalechange;
        transform1.localScale += scalechange;

        if (transform.localScale.y > 1f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (transform1.localScale.y > 1f)
        {
            transform1.localScale = new Vector3(1f, 1f, 1f);
        }


        if (Input.GetKeyDown(KeyCode.A)) //Left
        {
            GameObject.Find("GameManager").SendMessage("CheckCollisionLeft");
            transform.localScale = originalscale;
        }
        
        
        if (Input.GetKeyDown(KeyCode.D)) //Right
        {
            GameObject.Find("GameManager").SendMessage("CheckCollisionRight");
            transform1.localScale = originalscale;
        }


    }
}
