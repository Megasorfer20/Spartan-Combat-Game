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
    public int epada;
    public int escudo;
    public int casco;

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

        totalAtque = palyerStats.ataque + (5 * palyerUpgrades.epada);
        totalDefensa = palyerStats.defensa + (5 * palyerUpgrades.escudo);
        totalVida = palyerStats.vida + (5 * palyerUpgrades.casco);
    }
}

[CreateAssetMenu(fileName = "mainCharacter", menuName = "ScriptableObjects/ScriptCharacters", order = 1)]
public class ScriptCharacters : ScriptableObject
{
    public PlayerData playerData;
}
