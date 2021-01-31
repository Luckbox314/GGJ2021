using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSave : MonoBehaviour
{
    // Start is called before the first frame update
    public static LevelSave save;
    public int level = 2;

    void Awake(){

        if(save == null){
            save = this;
            DontDestroyOnLoad(gameObject);
            
        }
        else if(save != this){
            Destroy(gameObject);
        }

        

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Space key was pressed.");
            Debug.Log(level);
        }
        
    }

    // public void SetScene(){
    //     GameObject tittle = GameObject.Find("sil2");
    //     if(tittle == null){
    //         Debug.Log("Error al buscar tittle");
    //     }
    //     // Text textTitle = tittle.GetComponent<Text>();
    //     // tittle.Text = level;
    // }

}
