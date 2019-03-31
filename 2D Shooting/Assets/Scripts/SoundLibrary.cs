using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundLibrary : MonoBehaviour
{
    public AudioSource pickUp;
    public AudioSource explosion;

    // Start is called before the first frame update
    void Start()
    {
        pickUp = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayPickup()
    {
        pickUp.Play();
    }

    public void PlayExplosion()
    {
        explosion.Play();
    }
}
