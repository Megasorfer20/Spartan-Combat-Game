using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CombatState
{
    PlayerTurn,
    EnemyTurn
}


public struct Stats
{
    public int ataque;
    public int defensa;
    public int vida;
}

public class CombatManager : MonoBehaviour
{
    public ScriptCharacters charPlayer;
    public ScriptsEnemys charEnemy;

    private CombatState currentState;

    private Stats playerStats;
    private Stats enemyStats;

    private int accionJugador;
    private int accionEnemigo;

    void ActualizarPlayerData()
    {
        charPlayer.playerData.totalUpgrades = new TotalUpgrades(charPlayer.playerData.palyerStats, charPlayer.playerData.palyerUpgrades);
    }

    void Start()
    {

        ActualizarPlayerData();

        playerStats = new Stats
        {
            ataque = charPlayer.playerData.totalUpgrades.totalAtque,
            defensa = charPlayer.playerData.totalUpgrades.totalDefensa,
            vida = charPlayer.playerData.totalUpgrades.totalVida
        };

        enemyStats = new Stats
        {
            ataque = charEnemy.enemyStats.ataque,
            defensa = charEnemy.enemyStats.defensa,
            vida = charEnemy.enemyStats.vida
        };

        currentState = CombatState.PlayerTurn;

        Debug.Log("Debud De los stats del enemigo");
        Debug.Log(enemyStats.ataque);
        Debug.Log(enemyStats.defensa);
        Debug.Log(enemyStats.vida);

        Debug.Log("Debud De los stats del Jugador");
        Debug.Log(playerStats.ataque);
        Debug.Log(playerStats.defensa);
        Debug.Log(playerStats.vida);
    }

    void Update()
    {
        cambioDeTurno();
    }

    public void cambioDeTurno()
    {
        switch (currentState)
        {
            case CombatState.PlayerTurn:

                break;
            case CombatState.EnemyTurn:
                accionEnemigo = charEnemy.enemysTurnIA();
                break;
        }
    }

}
