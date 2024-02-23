using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;



public class guardadoPartida : MonoBehaviour
{
    public ScriptCharacters scriptCharacters;

    public void guardarPartida()
    {
        string json = JsonUtility.ToJson(scriptCharacters);
        File.WriteAllText(Application.persistentDataPath + "/guardado.json", json);
    }

    public void cargarPartida()
    {
        string path = Application.persistentDataPath + "/guardado.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            scriptCharacters = JsonUtility.FromJson<ScriptCharacters>(json);
        }
    }

    public void nuevoJuego()
    {
        scriptCharacters = new ScriptCharacters();
        guardarPartida();
    }
}