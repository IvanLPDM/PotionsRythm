//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GuardarCanciones : MonoBehaviour
//{
//    public List<GameObject> NotasInput;

//    public string archivoDeGuardado;

//    public GuardadoCancion guardadoCancion = new GuardadoCancion();

//    private void Awake()
//    {
//        archivoDeGuardado = Application.dataPath + "/datosJuego.json";

//        NotasInput = GameObject.FindGameObjectWithTag("ListaDePociones");
//    }

//    private void CargarDatos()
//    {
//        if (File.Exists(archivoDeGuardado))
//        {
//            string contenido = File.ReadAllText(archivoDeGuardado);
//            guardadoCancion = JsonUtility.FromJson<guardadoCancion>(contenido);

//            Debug.Log(guardadoCancion.Potions[0].transform);
//        }
//        else
//        {
//            Debug.Log("El archivo no existe");
//        }
//    }


//}
