using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ListaDePociones : MonoBehaviour
{
    public GameObject Save;

    public GameObject DobbleBarra;

    public TutorialManager tutorialManager;

    public GameObject PotionPrefab;
    public GameObject PotionLarge;

    private float time = 0;
    public float timeTranscurred = 0;

    public List<GameObject> PotionsInGameL;
    public List<GameObject> PotionsInGameR;
    public List<GameObject> Potions;

    public List<float> timing;
    public List<PotionsType> Mode;

    public List<float> LargeInGameL;
    public List<float> LargeInGameR;

    void Start()
    {
        if (!Save.activeInHierarchy)
        {
            GameObject.Find("LoadLevel").SendMessage("Load");
        }
    }

    void Update()
    {
        if(tutorialManager.paused == false)
            time += 1 * Time.deltaTime;
        
        //Aqui entraria la cancion y le diria cuando puede generar pociones
        if(timing.Count != 0)
        {
            if (timing[0] - 1.6 - time <= 0.01) //1.858648f
            {
                ExecutePotion();
                //Debug.Log(timing[0]);
                timing.RemoveAt(0);
            }
        }
        RemoveGame();
    }

    public void ExecutePotion()
    {
        if (Potions.Count != 0)
        {
            if(Mode[0] == PotionsType.NORMAL)
            {
                Potions[0].SetActive(true);
                PotionPrefab = Potions[0];

                if (PotionPrefab.transform.position.x == -0.77f)
                    PotionsInGameL.Add(PotionPrefab);
                else if (PotionPrefab.transform.position.x == 0.77f)
                    PotionsInGameR.Add(PotionPrefab);
            }
            else if(Mode[0] == PotionsType.LARGE)
            {
                Potions[0].SetActive(true);                
                PotionLarge = Potions[0];


                if (PotionLarge.transform.position.x == -0.77f)
                    PotionsInGameL.Add(PotionLarge);
                else if (PotionLarge.transform.position.x == 0.77f)
                    PotionsInGameR.Add(PotionLarge);
            }
            else if(Mode[0] == PotionsType.DOBBLE)
            {
                Potions[0].SetActive(true);
                PotionPrefab = Potions[0];

                if (PotionPrefab.transform.position.x == -0.77f)
                    PotionsInGameL.Add(PotionPrefab);
                else if (PotionPrefab.transform.position.x == 0.77f)
                    PotionsInGameR.Add(PotionPrefab);

                Instantiate(DobbleBarra);
            }

            Mode.RemoveAt(0);
            Potions.RemoveAt(0);
        }
    }

        public void RemoveGame()
    {
        if (PotionsInGameL.Count != 0)
        { 
            if (PotionsInGameL[0].transform.position.y <= -2.75f)
            {
                PotionsInGameL.RemoveAt(0);
            }
        }

        if (PotionsInGameR.Count != 0)
        {
            if (PotionsInGameR[0].transform.position.y <= -2.75f)
            {
                PotionsInGameR.RemoveAt(0);
            }
        }
    }

    public void DeleteInfo(int direccion)
    {
        if(direccion == 1)
        {
            LargeInGameR.RemoveAt(0);
        }
        else if(direccion == 2)
        {
            LargeInGameL.RemoveAt(0);
        }

    }

    public void LargeAntenaL()
    {
        if (LargeInGameL[0] > 0)
        {
            PotionsInGameL[0].SendMessage("Stay");
        }
    }

    public void LargeAntenaR()
    {
        if(LargeInGameR[0] > 0)
        {
            Debug.Log("Bien");
            PotionsInGameR[0].SendMessage("Stay");
        }
    }
    
    public void pausePotions()
    {
        for(int i = 0; i < PotionsInGameL.Count; i++)
        {
            PotionsInGameL[i].SendMessage("PausarTutorial");
        }

        for (int i = 0; i < PotionsInGameR.Count; i++)
        {
            PotionsInGameR[i].SendMessage("PausarTutorial");
        }
    }

    public void ReanudePotions()
    {
        for (int i = 0; i < PotionsInGameL.Count; i++)
        {
            PotionsInGameL[i].SendMessage("ReanudarTutorial");
        }

        for (int i = 0; i < PotionsInGameR.Count; i++)
        {
            PotionsInGameR[i].SendMessage("ReanudarTutorial");
        }
    }
}
