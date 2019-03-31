using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrankController : MonoBehaviour
{
    public GameObject crankDown;
    public GameObject oldWall;

    // Start is called before the first frame update
    void Start()
    {
        crankDown.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hello");
            Destroy(this.gameObject);
            crankDown.SetActive(true);
            oldWall.SetActive(false);
        }
       
    }
}
