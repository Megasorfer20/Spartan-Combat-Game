using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioEspada : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public ScriptCharacters scriptCharacters;

    public int nivelEspada;

    void SwitchObjects()
    {
        if (nivelEspada == 1)
        {
            object1.SetActive(true);
            object2.SetActive(false);
            object3.SetActive(false);
            object4.SetActive(false);
        }
        if (nivelEspada == 2)
        {
            object1.SetActive(false);
            object2.SetActive(true);
            object3.SetActive(false);
            object4.SetActive(false);
        }
        if (nivelEspada == 3)
        {
            object1.SetActive(false);
            object2.SetActive(false);
            object3.SetActive(true);
            object4.SetActive(false);
        }
        if (nivelEspada == 4)
        {
            object1.SetActive(false);
            object2.SetActive(false);
            object3.SetActive(false);
            object4.SetActive(true);
        }
    }
}
