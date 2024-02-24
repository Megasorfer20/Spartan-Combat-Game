using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CombatMovment
{
    none,
    atacar,
    defender,
    curar
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

    private int respuestaIA;

    private CombatMovment accionEnemigo;
    private CombatMovment accionPlayer;

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

        accionEnemigo = CombatMovment.none;
        accionPlayer = CombatMovment.none;

    }

    void Update()
    {
        cambioDeTurno();

        if (respuestaIA == 1)
        {
            accionEnemigo = CombatMovment.atacar;
        }
        else if (respuestaIA == 2)
        {
            accionEnemigo = CombatMovment.defender;
        }
        else if (respuestaIA == 3)
        {
            accionEnemigo = CombatMovment.curar;
        }
        else
        {
            accionEnemigo = CombatMovment.none;
        }
    }



    public void seleccionAtaque()
    {
        accionPlayer = CombatMovment.atacar;
        respuestaIA = charEnemy.enemysTurnIA(enemyStats.vida, playerStats.vida);
        logicaCombateHumano();
        accionPlayer = CombatMovment.none;

    }

    public void seleccionDefensa()
    {
        accionPlayer = CombatMovment.defender;
        respuestaIA = charEnemy.enemysTurnIA(enemyStats.vida, playerStats.vida);
        logicaCombateHumano();
        accionPlayer = CombatMovment.none;

    }

    public void seleccionCuracion()
    {
        accionPlayer = CombatMovment.curar;
        respuestaIA = charEnemy.enemysTurnIA(enemyStats.vida, playerStats.vida);
        logicaCombateHumano();
        accionPlayer = CombatMovment.none;

    }



private int calcularDefensa(){

}

private int calcularAtaque(int defensaPer, int ataqueCon){

}

private int calcularCuracion(int vidaPer){

}

    private void logicaCombateHumano(){

        private int valorOperacion = 0;

        if(accionPlayer == CombatMovment.defender || accionEnemigo == CombatMovment.defender){
            if (accionPlayer == CombatMovment.defender && accionEnemigo == CombatMovment.defender && accionPlayer == CombatMovment.atacar)
            {
                
            }

            if (accionPlayer == CombatMovment.defender && accionEnemigo !== CombatMovment.defender && accionEnemigo == accionEnemigo !== CombatMovment.defender)
            {
                
            }
        } else {
            if (true)
            {
                
            }

            if (true)
            {
                
            }


        }


    }

private void logicaCombateEnemy(int valorAtaquePlayer){

}
}
