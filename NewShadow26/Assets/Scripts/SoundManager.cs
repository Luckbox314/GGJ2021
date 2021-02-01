using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{

    //public AudioMixer mainAudioMixer;
    public AudioSource[] audioSources;
    private bool soundOn = true;

    //public void ToggleSound()
    //{
    //    if (soundOn)
    //    {
    //        mainAudioMixer.SetFloat("Master", Mathf.Log10(-1) * 20);
    //        soundOn = false;
    //    }
    //    else
    //    {
    //        mainAudioMixer.SetFloat("Master", Mathf.Log10(0) * 20);
    //        soundOn = true;
    //    }
    //}
    void Awake()
    {
        UpdateSound();

    }

    public void UpdateSound()
    {
        soundOn = ImmortalObject.immortalObject.soundOn;
        if (soundOn)
        {
            foreach (var audioSource in audioSources)
            {
                audioSource.mute = false;
            }
        }
        else
        {
            foreach (var audioSource in audioSources)
            {
                audioSource.mute = true;
            }
        }


    }

    public void ToggleSound()
    {
        ImmortalObject.immortalObject.soundOn = !ImmortalObject.immortalObject.soundOn;
        UpdateSound();
    }

}
