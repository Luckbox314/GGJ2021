using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    private void Awake()
    {
        gameManager = this;

    }
    public void NextLevel(int level)
    {

        SceneManager.LoadScene(level);
    }

}
