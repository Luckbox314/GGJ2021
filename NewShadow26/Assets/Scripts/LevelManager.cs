using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public void Buttonclick(int levelButton){
        levelButton += 1;
        GameObject levelSave = GameObject.Find("LevelSave");
        int maxLevelUnlocked = levelSave.GetComponent<LevelSave>().level;
        if(levelButton > maxLevelUnlocked){
            Debug.Log("Aún no has alcanzado ese nivel");
        }
        else{
            Debug.Log("cargando nivel");

            // string sceneName = "Level" + levelButton.ToString();
            SceneManager.LoadScene(levelButton);

        }   
    }
    
    public void Level1(){
        SceneManager.LoadScene("Level1");
    }

    public void Descubre(){
        SceneManager.LoadScene("Descubre");
    }

}
