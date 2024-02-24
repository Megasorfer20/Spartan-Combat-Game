using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurnIA : MonoBehaviour
{
    private string lastChose = "";
    private string pastLastChose = "";

    private int ataqueEnemy(int valorAtaque)
    {
        return 1;
    }

    private int defenseEnemy(int valorDefensa, int ataqueEnemigo)
    {
        return 1;
    }

    private int curacionEnemy(int valorVida)
    {
        return 1;
    }

    public int enemysTurnIA(int valorAtaque, int valorDefensa, int valorVida, int ataqueEnemigo, int vidaEenemigo)
    {
        if (lastChose == "" && pastLastChose == "")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return curacionEnemy(valorVida);
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return defenseEnemy(valorDefensa, ataqueEnemigo);
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return ataqueEnemy(valorAtaque);
            }
        }
        else if (lastChose == "ataque" && pastLastChose == "")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return curacionEnemy(valorVida);
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return ataqueEnemy(valorAtaque);
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return ataqueEnemy(valorAtaque);
            }
        }
        else if (lastChose == "defensa" && pastLastChose == "")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return curacionEnemy(valorVida);
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return ataqueEnemy(valorAtaque);
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return ataqueEnemy(valorAtaque);
            }
        }
        else if (lastChose == "vida" && pastLastChose == "")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return curacionEnemy(valorVida);
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return ataqueEnemy(valorAtaque);
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return defenseEnemy(valorDefensa, ataqueEnemigo);
            }
        }
        else if (lastChose == "ataque" && pastLastChose == "ataque")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return curacionEnemy(valorVida);
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return defenseEnemy(valorDefensa, ataqueEnemigo);
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return defenseEnemy(valorDefensa, ataqueEnemigo);
            }
        }
        else if (lastChose == "defensa" && pastLastChose == "ataque")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return curacionEnemy(valorVida);
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return ataqueEnemy(valorAtaque);
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return defenseEnemy(valorDefensa, ataqueEnemigo);
            }
        }
        else if (lastChose == "vida" && pastLastChose == "ataque")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return curacionEnemy(valorVida);
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return ataqueEnemy(valorAtaque);
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return ataqueEnemy(valorAtaque);
            }
        }
        else if (lastChose == "ataque" && pastLastChose == "defensa")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return curacionEnemy(valorVida);
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return defenseEnemy(valorDefensa, ataqueEnemigo);
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return ataqueEnemy(valorAtaque);
            }
        }
        else if (lastChose == "defensa" && pastLastChose == "defensa")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return curacionEnemy(valorVida);
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return ataqueEnemy(valorAtaque);
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return curacionEnemy(valorVida);
            }
        }
        else if (lastChose == "vida" && pastLastChose == "defensa")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return curacionEnemy(valorVida);
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return ataqueEnemy(valorAtaque);
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return curacionEnemy(valorVida);
            }
        }
        else if (lastChose == "ataque" && pastLastChose == "vida")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return curacionEnemy(valorVida);
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return defenseEnemy(valorDefensa, ataqueEnemigo);
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return ataqueEnemy(valorAtaque);
            }
        }
        else if (lastChose == "defensa" && pastLastChose == "vida")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "vida";
                return curacionEnemy(valorVida);
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return ataqueEnemy(valorAtaque);
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "ataque";
                return ataqueEnemy(valorAtaque);
            }
        }
        else if (lastChose == "vida" && pastLastChose == "vida")
        {
            if (valorVida < (valorVida * 15) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return defenseEnemy(valorDefensa, ataqueEnemigo);
            }
            else if (vidaEenemigo > (vidaEenemigo * 50) / 100)
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return defenseEnemy(valorDefensa, ataqueEnemigo);
            }
            else
            {
                pastLastChose = lastChose;
                lastChose = "defensa";
                return defenseEnemy(valorDefensa, ataqueEnemigo);
            }
        }
        else
        {
            pastLastChose = lastChose;
            lastChose = "ataque";
            return ataqueEnemy(valorAtaque);
        }
    }

}
