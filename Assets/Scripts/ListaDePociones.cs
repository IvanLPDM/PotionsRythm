using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ListaDePociones : MonoBehaviour
{
    public GameObject PotionPrefab;
    private float time = 0;
    public float timeTranscurred = 0;

    public List<GameObject> PotionsInGameL;
    public List<GameObject> PotionsInGameR;
    public List<GameObject> Potions;
    public List<float> timing;

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
}
