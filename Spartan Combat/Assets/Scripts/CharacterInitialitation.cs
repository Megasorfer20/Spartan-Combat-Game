using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInitialitation : MonoBehaviour
{
    public ScriptCharacters scriptCharacters;

    void Awake()
    {
        ActualizarPlayerData();
    }

    void ActualizarPlayerData()
    {
        scriptCharacters.playerData.totalUpgrades = new TotalUpgrades(scriptCharacters.playerData.palyerStats, scriptCharacters.playerData.palyerUpgrades);
    }
}
