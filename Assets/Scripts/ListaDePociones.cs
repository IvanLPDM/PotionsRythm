using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaDePociones : MonoBehaviour
{
    public GameObject PotionPrefab;
    private float time = 0;

    public List<GameObject> PotionsInGameL;
    public List<GameObject> PotionsInGameR;
    public List<GameObject> Potions;

    void Start()
    {
        GeneratePotions();
    }

    void Update()
    {

        time++;

        //Aqui entraria la cancion y le diria cuando puede generar pociones
        if(time % 100 == 0)
        {
            ExecutePotion();
        }

        RemoveGame();
    }

    public void ExecutePotion()
    {
        if (Potions.Count != 0)
        {
            //int numRand = Random.Range(1, 2);

            Potions[0].SetActive(true);
            PotionPrefab = Potions[0];

            if(PotionPrefab.transform.position.x == -0.77f)
                PotionsInGameL.Add(PotionPrefab);
            else if (PotionPrefab.transform.position.x == 0.77f)
                PotionsInGameR.Add(PotionPrefab);

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

    public void GeneratePotions()
    {
        for(int i = 0; i < 70; i++)
        {
            int numRand = 0;
            numRand = Random.Range(0, 2);

            if (numRand == 0)
                Potions.Add(Instantiate(PotionPrefab, new Vector2(0.77f, 3.8f), Quaternion.identity));
            else
                Potions.Add(Instantiate(PotionPrefab, new Vector2(-0.77f, 3.8f), Quaternion.identity));

            Potions[i].SetActive(false);

            //Potions[i].
        }
    }
}
