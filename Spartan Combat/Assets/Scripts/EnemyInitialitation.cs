using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInitialitation : MonoBehaviour
{
    public ScriptsEnemys scriptsEnemys;

    void Awake()
    {
        Debug.Log(scriptsEnemys.enemyStats.ataque);
        Debug.Log(scriptsEnemys.enemyStats.defensa);
        Debug.Log(scriptsEnemys.enemyStats.vida);
    }

}
