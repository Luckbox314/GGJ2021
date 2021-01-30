using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class ToggleLightSources : MonoBehaviour
{
    [Header("La fuente de luz y sombras 1")]
    public GameObject luz1;
    public GameObject[] sombras1;
    [Header("La fuente de luz y sombras 2")]
    public GameObject luz2;
    public GameObject[] sombras2;
    private bool lightState = true;


    private void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            lightState = !lightState;
            if (lightState) { luz1.SetActive(true); luz2.SetActive(false); }
            else { luz2.SetActive(true); luz1.SetActive(false); }
            
            
        }

    }

}
