using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmortalObject : MonoBehaviour
{
    public static ImmortalObject immortalObject;
    public bool soundOn = true;

    void Awake()
    {    
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Immortal");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        immortalObject = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
