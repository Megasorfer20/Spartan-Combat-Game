using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class PlayerData
{
    public bool level1;
    public bool level2;
    public bool level3;
    public int monedas;
    public PalyerStats palyerStats;

}

[System.Serializable]
public class PalyerStats
{
    public int ataque;
    public int defensa;
    public int curacion;

}

public class guardadoPartida : MonoBehaviour
{
    public PlayerData playerData;

    public void guardarPartida()
    {
        string json = JsonUtility.ToJson(playerData);
        File.WriteAllText(Application.persistentDataPath + "/guardado.json", json);
    }

    public void cargarPartida()
    {
        string path = Application.persistentDataPath + "/guardado.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            playerData = JsonUtility.FromJson<PlayerData>(json);
        }
    }

    public void nuevoJuego()
    {
        playerData = new PlayerData();
        guardarPartida();
    }
}