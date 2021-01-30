using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLightSources : MonoBehaviour
{
    
    
    [Header("La fuente de luz y sombras 1")]
    public GameObject[] luces;

    private bool lightState = false;
    [Header("La fuente de luz y sombras 2")]
    public GameObject noLuz;

    private int luzActual = 0;


    private void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            if(noLuz != null){noLuz.SetActive(false);}
            CambiarLuz();
        }
    }


    void CambiarLuz()
    {
        int numLuces = luces.Length;
        Debug.Log("numLuces: " + numLuces);
        Debug.Log("luzActual: " + luzActual);
        foreach (var luz in luces)
        {
            luz.SetActive(false);
        }
        luces[luzActual].SetActive(true);
        luzActual += 1;
        if (luzActual >= numLuces)
        {
            luzActual = 0;
        }
        

    }

}
