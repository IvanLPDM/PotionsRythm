using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System.Xml.Serialization;

public enum PotionsType
{
    LARGE,
    NORMAL,
    DOBBLE
};

public class SavedPotion
{
    public int direccion;
    public float time;
    public PotionsType mode;
    public float duration;

    public SavedPotion(int direccion_, float time_, PotionsType mode_, float duration_)
    {
        this.direccion = direccion_;
        this.time = time_;
        this.mode = mode_;
        this.duration = duration_;
    }

    public SavedPotion()
    {
        this.direccion = 0;
        this.time = 0.0f;
        this.mode = PotionsType.NORMAL;
        this.duration = 0.0f;
    }
}



public class CrearNuevaCanion : MonoBehaviour
{
    public List<SavedPotion> PotionsToSave = new List<SavedPotion>();
    private float time;
    private float timeSavedPotionL;
    private float timeSavedPotionR;
    public string FileName;
    public ListaDePociones PotionsGame;

    private float StartTimeLargeL;
    private float largeL;
    private bool StartSaveL;

    private float StartTimeLargeR;
    private float largeR;
    private bool StartSaveR;

    // Start is called before the first frame update
    void Start()
    {
        StartSaveL = false;
        StartTimeLargeL = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += 1 * Time.deltaTime;

        //Aqui entraria la cancion y le diria cuando puede generar pociones
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartSaveL = true;
            timeSavedPotionL = time;
            //Si es mantenida que guarde mantenida sino normal, y que se guarde el tiempo mantenido desde Input
        }

        if(StartSaveL == true)
        {
            if (Input.GetKey(KeyCode.A)) //Left
            {
                //Empezar a contar
                StartTimeLargeL += 1 * Time.deltaTime;
            }

            if (Input.GetKeyUp(KeyCode.A)) //Left
            {
                //Dejar de contar
                if (StartTimeLargeL >= 0.3f)
                {
                    largeL = StartTimeLargeL;

                    Debug.Log(largeL);

                    PotionsToSave.Add(new SavedPotion(0, timeSavedPotionL, PotionsType.LARGE, largeL));
                    Debug.Log("Guardado Izquierda min:" + timeSavedPotionL);
                    //Llamar funcion de mantenida   
                }
                else
                {
                    PotionsToSave.Add(new SavedPotion(0, timeSavedPotionL, PotionsType.NORMAL, 0.0f));
                    Debug.Log("Guardado Izquierda min:" + timeSavedPotionL);
                }
                StartTimeLargeL = 0.0f;
            } 
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            StartSaveR = true;
            timeSavedPotionR = time;
            //Si es mantenida que guarde mantenida sino normal, y que se guarde el tiempo mantenido desde Input
        }

        if (StartSaveR == true)
        {
            if (Input.GetKey(KeyCode.D)) //Left
            {
                //Empezar a contar
                StartTimeLargeR += 1 * Time.deltaTime;
            }

            if (Input.GetKeyUp(KeyCode.D)) //Left
            {
                //Dejar de contar
                if (StartTimeLargeR >= 0.3f)
                {
                    largeR = StartTimeLargeR;

                    PotionsToSave.Add(new SavedPotion(1, timeSavedPotionR, PotionsType.LARGE, largeR));
                    Debug.Log("Guardado Derecha min:" + timeSavedPotionR);
                    //Llamar funcion de mantenida   
                }
                else
                {
                    PotionsToSave.Add(new SavedPotion(1, timeSavedPotionR, PotionsType.NORMAL, 0.0f));
                    Debug.Log("Guardado Derecha min:" + timeSavedPotionR);
                }
                StartTimeLargeR = 0.0f;
            }
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            Save();
            Debug.Log("Guardado");
        }
    }

    public void Save()
    {
        List<SavedPotion> data = new List<SavedPotion>();

        
            for (int i = 0; i < PotionsToSave.Count; i++)
            {
                data.Add(PotionsToSave[i]);
            }
            //Obtenemos la ruta de streamingAssets
            //Crea o abre el archivo
            //Modo escritura
            var file = new FileStream(Application.streamingAssetsPath + "/" + FileName + ".xml",
                FileMode.OpenOrCreate,
                FileAccess.Write);

            //Borra los datos antiguos y crea nuevos
            file.SetLength(0);

            //Creamos un formateador que nos pide un tipo de guardado
            var formatter = new XmlSerializer(typeof(List<SavedPotion>));

            //Escribimos en el archivo
            formatter.Serialize(file, data);
            file.Close();
      
    }

   


}
