using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int nextLevel;
    public AudioSource end;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("sad");
        GameManager.gameManager.NextLevel(nextLevel);
        end.Play();
    }
}
