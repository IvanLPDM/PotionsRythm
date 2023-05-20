using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System.Xml.Serialization;

public class LoadSong : MonoBehaviour
{
    public string FileName;
    public ListaDePociones PotionsGame;

    public PotionsType potionsType;

    public void Load()
    {
        /*
        var file = new FileStream(Application.streamingAssetsPath + "/" + FileName + ".xml",
        FileMode.Open,
        FileAccess.Read);

        //Creamos un formateador que nos pide un tipo de guardado
        var formatter = new XmlSerializer(typeof(List<SavedPotion>));
        var data = formatter.Deserialize(file) as List<SavedPotion>;
        */

        TextAsset file = Resources.Load(FileName) as TextAsset;
        var formatter = new XmlSerializer(typeof(List<SavedPotion>));
        var data = formatter.Deserialize(new System.IO.StringReader(file.text)) as List<SavedPotion>;

        for (int i = 0; i < data.Count; i++)
        {
            //Añadir lo guardado en la lista de pociones
            if(data[i].mode == PotionsType.NORMAL || data[i].mode == PotionsType.DOBBLE)
            {
                if (data[i].direccion == 1) //Left
                {
                    PotionsGame.Potions.Add(Instantiate(PotionsGame.PotionPrefab, new Vector2(0.77f, 3.8f), Quaternion.identity));
                    PotionsGame.LargeInGameR.Add(data[i].duration);
                }
                else //Right
                {
                    PotionsGame.Potions.Add(Instantiate(PotionsGame.PotionPrefab, new Vector2(-0.77f, 3.8f), Quaternion.identity));
                    PotionsGame.LargeInGameL.Add(data[i].duration);
                }
            }
            else if (data[i].mode == PotionsType.LARGE)
            {
                GameObject.Find("PocionLarga").SendMessage("ChangeLarge", data[i].duration);

                if (data[i].direccion == 1) //Right
                {
                    PotionsGame.Potions.Add(Instantiate(PotionsGame.PotionLarge, new Vector2(0.77f, 3.8f), Quaternion.identity));
                    PotionsGame.LargeInGameR.Add(data[i].duration);
                }
                else //Left
                {
                    PotionsGame.Potions.Add(Instantiate(PotionsGame.PotionLarge, new Vector2(-0.77f, 3.8f), Quaternion.identity));
                    PotionsGame.LargeInGameL.Add(data[i].duration);
                }
            }

            //Guardar en una lista como de largas son si son mantenida
            PotionsGame.Mode.Add(data[i].mode);

            PotionsGame.timing.Add(data[i].time);
            PotionsGame.Potions[i].SetActive(false);
        }
    }
}
