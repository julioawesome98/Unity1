using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colores : MonoBehaviour
{
    public bool esColores = false;
    private Renderer colorEsfera;
    public UnityEngine.Color color;
    void start()
    {
        colorEsfera = GetComponent<Renderer>();
        colorEsfera.material.color=color;
        esColores = true;
    }
    void uptade()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            colorChange();
        }

    }

    public void colorChange()
    {
        if (esColores == true)
        {
            colorEsfera.material.color = UnityEngine.Color.red;
            esColores = false;
        }
        else
        {
            colorEsfera.material.color=UnityEngine.Color.blue;
            esColores = true;
        }
    }
}
