using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System.Xml.Serialization;

public class LoadSong : MonoBehaviour
{
    public string FileName;
    public ListaDePociones PotionsGame;


    public void Load()
    {
        if (File.Exists(Application.streamingAssetsPath + "/" + FileName + ".xml"))
        {
            var file = new FileStream(Application.streamingAssetsPath + "/" + FileName + ".xml",
            FileMode.Open,
            FileAccess.Read);

            //Creamos un formateador que nos pide un tipo de guardado
            var formatter = new XmlSerializer(typeof(List<SavedPotion>));
            var data = formatter.Deserialize(file) as List<SavedPotion>;

            for (int i = 0; i < data.Count; i++)
            {
                //Añadir lo guardado en la lista de pociones
                if (data[i].direccion == 1)
                    PotionsGame.Potions.Add(Instantiate(PotionsGame.PotionPrefab, new Vector2(0.77f, 3.8f), Quaternion.identity));
                else
                    PotionsGame.Potions.Add(Instantiate(PotionsGame.PotionPrefab, new Vector2(-0.77f, 3.8f), Quaternion.identity));

                PotionsGame.timing.Add(data[i].time);
                PotionsGame.Potions[i].SetActive(false);
            }

            file.Close();
        }
    }
}
