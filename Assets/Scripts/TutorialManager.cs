using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public int fasesAnimacion = 0;
    public float time = 0;
    public bool paused = false;
    public GameObject[] flechas;

    public bool clickado;
    public bool clickadoOn;

    public float Next;

    public GameObject[] TextList;
    public GameObject[] Magos;

    // Start is called before the first frame update
    void Start()
    {
        Next = 0f;

        clickado = false;
        clickadoOn = false;

        Magos[0].SetActive(false);  
        
        for(int i = 0; i <= TextList.Length; i++)
        {
            TextList[i].SetActive(false);
        }

        for(int i = 0; i <= Magos.Length; i++)
        {
            Magos[i].SetActive(false);
        }

        for(int i = 0; i <= flechas.Length; i++)
        {
            flechas[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
            time += 1 * Time.deltaTime;



        if (time >= 70)
        {
            TextList[9].SetActive(false);
            Magos[2].SetActive(false);

            paused = false;
        }
        else if (time >= 64)
        {
            TextList[9].SetActive(true);
            Magos[2].SetActive(true);

            paused = true;
        }
        else if (time >= 57)
        {
            paused = false;
            GameObject.Find("CreadorPociones").SendMessage("ReanudePotions");

            TextList[8].SetActive(false);
            Magos[2].SetActive(false);
        }
        else if (time >= 52)
        {
            paused = true;
            GameObject.Find("CreadorPociones").SendMessage("pausePotions");

            TextList[8].SetActive(true);
            Magos[2].SetActive(true);

        }
        else if (time >= 50)
        {
            Magos[1].SetActive(false);

            TextList[7].SetActive(false);

            paused = false;

            GameObject.Find("CreadorPociones").SendMessage("ReanudePotions");
        }
        else if (time >= 42)
        {
            TextList[6].SetActive(false);
            TextList[7].SetActive(true);

            flechas[1].SetActive(false);
            flechas[2].SetActive(false);

        }
        else if (time >= 34)
        {
            TextList[5].SetActive(false);
            TextList[6].SetActive(true);

            flechas[1].SetActive(true);
            flechas[2].SetActive(true);

            flechas[0].SetActive(false);
        }
        else if(time >= 32)
        {
            TextList[5].SetActive(false);
            flechas[0].SetActive(false);
        }
        else if (time >= 26.5)
        {
            flechas[0].SetActive(true);

            TextList[4].SetActive(false);
            TextList[5].SetActive(true);

            //flecha
        }
        else if (time >= 20.5)
        {
            TextList[3].SetActive(false);
            TextList[4].SetActive(true);
        }
        else if (time >= 15.5)
        {
            TextList[3].SetActive(true);
        }
        else if (time >= 15 && clickado == false)
        {
            Next += 1 * Time.deltaTime;

            //TextList[1].SetActive(false);

            if (Next <= 1)
            {
                TextList[2].SetActive(true);
            }
            else if (Next > 1 && Next <= 2)
            {
                TextList[2].SetActive(false);
            }
            else
                Next = 0f;

            clickadoOn = true;

            time = 15f;
        }
        else if(time >= 15 && clickado == true)
        {
            Debug.Log("MagoTemblando");
            TextList[1].SetActive(false);
            TextList[2].SetActive(false);
            

            Magos[0].SetActive(false);
            Magos[1].SetActive(true);

            clickado = false;
            clickadoOn = false;
            time = 15.5f;
        }
        else if (time >= 10)
        {
            TextList[1].SetActive(true);
            TextList[0].SetActive(false);
        }
        else if (time >= 5.7 && paused == false)
        {
            time += 1 * Time.deltaTime;
            paused = true;
            Magos[0].SetActive(true);
            TextList[0].SetActive(true);

            GameObject.Find("CreadorPociones").SendMessage("pausePotions");
        }
        


    }
}
