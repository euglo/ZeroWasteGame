using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool hit = false;
    public static bool updated = false;
    public static int lives = 4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void EndGame()
    {
        if (hit && !updated)
        {
            lives--;
            updated = true;
        }

        if (lives >= 0)
        {
            Invoke("Restart", 2f);
        }
        else
        {
            Invoke("GameOver", 2f);
        }
    }
    public void Restart()
    {
        Score.bottles = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        GameManager.lives = 4;
        SceneManager.LoadScene(0);
    }
}
