using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLightSources : MonoBehaviour
{
    [Header("La fuente de luz y sombras 1")]
    public GameObject luz1;
    [Header("La fuente de luz y sombras 2")]
    public GameObject luz2;
    private bool lightState = false;
    [Header("La fuente de luz y sombras 2")]
    public GameObject noLuz;


    private void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            noLuz.SetActive(false);
            lightState = !lightState;
            if (lightState) { luz1.SetActive(true); luz2.SetActive(false); }
            else { luz2.SetActive(true); luz1.SetActive(false); }  
        }
    }
}
