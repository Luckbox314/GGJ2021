using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLightSources : MonoBehaviour
{
    
    
    [Header("Las fuentes de luz")]
    public GameObject[] luces;

    private bool lightState = false;
    [Header("La fuente de luz original")]
    public GameObject sombraOriginal;

    // Esto determina que luz deberia prenderse al precionar espacio.
    private int luzActual = 0;

    private void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            // Desactiva la sombra original 
            if(sombraOriginal != null){ sombraOriginal.SetActive(false);}
            CambiarLuz();
        }
    }

    void CambiarLuz()
    {
        int numLuces = luces.Length;
        foreach (var luz in luces){luz.SetActive(false);}
        luces[luzActual].SetActive(true);
        luzActual += 1;
        if (luzActual >= numLuces){luzActual = 0;}
    }
}
