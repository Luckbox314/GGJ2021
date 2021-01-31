using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScenes : MonoBehaviour
{
    
    public void Level1(){
        SceneManager.LoadScene("Level1");
    }

    public void SelectLevel(){
        SceneManager.LoadScene("Select Level");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }

}
