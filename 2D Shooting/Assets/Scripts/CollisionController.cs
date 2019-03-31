using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionController : MonoBehaviour
{
    public GameObject tree;
    public GameObject deathEffect;

    // Start is called before the first frame update
    void Start()
    {
        tree.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Trap") || other.gameObject.CompareTag("Enemy"))
        {
            GameManager.hit = true;
            GameManager.updated = false;
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            FindObjectOfType<GameManager>().EndGame();
        }

        if (other.gameObject.CompareTag("EndPlatform") && Score.bottles >= 5)
        {
            Score.bottles = 0;
            GameManager.lives = 4;
            tree.gameObject.SetActive(true);
            Invoke("NextLevel", 3f);
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
