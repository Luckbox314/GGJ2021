using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int nextLevel;
    public AudioSource end;

    void Start()
    {
        end = GetComponent<AudioSource>();
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("sad");
        GameObject levelSave = GameObject.Find("LevelSave");
        int maxLevelUnlocked = levelSave.GetComponent<LevelSave>().level;
        if(nextLevel > maxLevelUnlocked){
            levelSave.GetComponent<LevelSave>().level = nextLevel;
        }
        
        GameManager.gameManager.NextLevel(nextLevel);
        end.Play();
    }
}
