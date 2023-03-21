using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ListaDePociones : MonoBehaviour
{
    public GameObject PotionPrefab;
    public GameObject PotionLarge;

    private float time = 0;
    public float timeTranscurred = 0;

    public List<GameObject> PotionsInGameL;
    public List<GameObject> PotionsInGameR;
    public List<GameObject> Potions;

    public List<float> timing;
    public List<float> Large;
    public List<PotionsType> Mode; 

    void Start()
    {
        GameObject.Find("LoadLevel").SendMessage("Load");
    }

    void Update()
    {

        time += 1 * Time.deltaTime;
        

        //Aqui entraria la cancion y le diria cuando puede generar pociones
        if(timing.Count != 0)
        {
            if (timing[0] - 1.6 - time <= 0.01) //1.858648f
            {
                ExecutePotion();
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

            Large.RemoveAt(0);
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
}
