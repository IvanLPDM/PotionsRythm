using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System.Xml.Serialization;


public class SavedPotion
{
    public int direccion;
    public float time;

    public SavedPotion(int direccion_, float time_)
    {
        this.direccion = direccion_;
        this.time = time_;
    }

    public SavedPotion()
    {
        this.direccion = 0;
        this.time = 0.0f;
    }
}



public class CrearNuevaCanion : MonoBehaviour
{
    public List<SavedPotion> PotionsToSave = new List<SavedPotion>();
    private float time;
    public string FileName;
    public ListaDePociones PotionsGame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += 1 * Time.deltaTime;

        //Aqui entraria la cancion y le diria cuando puede generar pociones
        if (Input.GetKeyDown(KeyCode.A))
        {
            PotionsToSave.Add(new SavedPotion(0, time));
            Debug.Log("Guardado Izquierda min:" + time);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            PotionsToSave.Add(new SavedPotion(1, time));
            Debug.Log("Guardado Derecha min:" + time);
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
