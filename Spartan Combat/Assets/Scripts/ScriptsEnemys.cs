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
}
