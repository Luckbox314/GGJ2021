using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource fall;
    public AudioSource jump;
    // Start is called before the first frame update
    void Start()
    {
        fall = gameObject.AddComponent<AudioSource>();
        jump = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
