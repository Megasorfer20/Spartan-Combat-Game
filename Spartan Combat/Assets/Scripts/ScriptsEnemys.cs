using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyStats
{
    public int ataque;
    public int defensa;
    public int vida;

}

[CreateAssetMenu(fileName = "enemyCharacter", menuName = "ScriptableObjects/ScriptEnemys", order =2)]
public class ScriptsEnemys : ScriptableObject
{
    public EnemyStats enemyStats;

    private string lastChose = "";
    private string pastLastChose = "";

    public int enemysTurnIA(int valorAtaque, int valorDefensa, int valorVida, int ataqueEnemigo, int vidaEenemigo)
    {
        if (lastChose == "" && pastLastChose == "")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return 3;
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return 2;
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return 1;
            }
        }
        else if (lastChose == "ataque" && pastLastChose == "")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return 3;
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return 1;
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return 1;
            }
        }
        else if (lastChose == "defensa" && pastLastChose == "")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return 3;
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return 1;
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return 1;
            }
        }
        else if (lastChose == "vida" && pastLastChose == "")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return 3;
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return 1;
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return 2;
            }
        }
        else if (lastChose == "ataque" && pastLastChose == "ataque")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return 3;
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return 2;
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return 2;
            }
        }
        else if (lastChose == "defensa" && pastLastChose == "ataque")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return 3;
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return 1;
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return 2;
            }
        }
        else if (lastChose == "vida" && pastLastChose == "ataque")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return 3;
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return 1;
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return 1;
            }
        }
        else if (lastChose == "ataque" && pastLastChose == "defensa")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return 3;
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return 2;
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return 1;
            }
        }
        else if (lastChose == "defensa" && pastLastChose == "defensa")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return 3;
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return 1;
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return 3;
            }
        }
        else if (lastChose == "vida" && pastLastChose == "defensa")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return 3;
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return 1;
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return 3;
            }
        }
        else if (lastChose == "ataque" && pastLastChose == "vida")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return 3;
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return 2;
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return 1;
            }
        }
        else if (lastChose == "defensa" && pastLastChose == "vida")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return 3;
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return 1;
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return 1;
            }
        }
        else if (lastChose == "vida" && pastLastChose == "vida")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return 2;
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return 2;
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return 2;
            }
        }
        else
        {
            pastLastChose = lastChose;
            lastChose = "ataque";
            return 1;
        }
    }
}
