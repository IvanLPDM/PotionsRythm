using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSaveManager : MonoBehaviour
{
    public GameObject Save;
    public GameObject Load;

    public void Desactivate()
    {
        if(Save.activeInHierarchy)
        {
            Save.SetActive(false);
            Load.SetActive(true);
        }
        else
        {
            Save.SetActive(true);
            Load.SetActive(false);
        }
    }
}
