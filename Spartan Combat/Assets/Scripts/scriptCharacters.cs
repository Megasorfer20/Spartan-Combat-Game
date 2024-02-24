using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerData
{
    public bool level1;
    public bool level2;
    public bool level3;
    public int monedas;
    public PalyerStats palyerStats;
    public PalyerUpgrades palyerUpgrades;
    public TotalUpgrades totalUpgrades;

    public PlayerData()
    {
        palyerStats = new PalyerStats();
        palyerUpgrades = new PalyerUpgrades();
        totalUpgrades = new TotalUpgrades(palyerStats, palyerUpgrades);
    }
}

[System.Serializable]
public class PalyerStats
{
    public int ataque;
    public int defensa;
    public int vida;

}

[System.Serializable]
public class PalyerUpgrades
{

    public delegate void OnUpgradeChange();
    public static event OnUpgradeChange onEspadaChange;
    public static event OnUpgradeChange onEscudoChange;
    public static event OnUpgradeChange onCascoChange;

    public int _espada;
    public int espada
    {
        get { return _espada; }
        set
        {
            _espada = value;
            if (onEspadaChange != null)
            {
                onEspadaChange.Invoke();
            }
        }
    }
    public int _escudo;
    public int escudo{
        get { return _escudo; }
        set
        {
            _escudo = value;
            if (onEscudoChange != null)
            {
                onEscudoChange.Invoke();
            }
        }
    }
    public int _casco;
    public int casco{
        get { return _casco; }
        set
        {
            _casco = value;
            if (onCascoChange != null)
            {
                onCascoChange.Invoke();
            }
        }
    }

}

public class TotalUpgrades
{
    public PalyerStats palyerStats;
    public PalyerUpgrades palyerUpgrades;

    public int totalAtque;
    public int totalDefensa;
    public int totalVida;

    public TotalUpgrades(PalyerStats palyerStats, PalyerUpgrades palyerUpgrades)
    {
        this.palyerStats = palyerStats;
        this.palyerUpgrades = palyerUpgrades;

        totalAtque = palyerStats.ataque + (5 * palyerUpgrades.espada);
        totalDefensa = palyerStats.defensa + (5 * palyerUpgrades.escudo);
        totalVida = palyerStats.vida + (5 * palyerUpgrades.casco);
    }
}

[CreateAssetMenu(fileName = "mainCharacter", menuName = "ScriptableObjects/ScriptCharacters", order = 1)]
public class ScriptCharacters : ScriptableObject
{
    public PlayerData playerData;
}
