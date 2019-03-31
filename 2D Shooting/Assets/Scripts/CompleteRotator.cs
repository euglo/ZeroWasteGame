using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteRotator : MonoBehaviour
{
    public SoundLibrary soundLib;
    // Update is called once per frame
    void Update()
    {
        //Rotate thet transform of the game object this is attached to by 45 degrees, taking into account the time elapsed since last frame.
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }



    public void Start()
    {
    }

    public void YourMethodNameHere()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("Player"))
        {
            Score.bottles += 1;
            FindObjectOfType<SoundLibrary>().PlayPickup();
            gameObject.SetActive(false);
        }
    }
}
