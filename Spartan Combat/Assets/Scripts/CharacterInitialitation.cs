using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInitialitation : MonoBehaviour
{
    public ScriptCharacters scriptCharacters;

    void Awake()
    {
        ActualizarPlayerData();
        Debug.Log(scriptCharacters.playerData.totalUpgrades.totalAtque);
        Debug.Log(scriptCharacters.playerData.totalUpgrades.totalDefensa);
        Debug.Log(scriptCharacters.playerData.totalUpgrades.totalVida);
    }

    void ActualizarPlayerData()
    {
        scriptCharacters.playerData.totalUpgrades = new TotalUpgrades(scriptCharacters.playerData.palyerStats, scriptCharacters.playerData.palyerUpgrades);
    }
}
