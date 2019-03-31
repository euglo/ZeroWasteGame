using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int health = 100;

	public GameObject deathEffect;
    public GameObject drop;
    public SoundLibrary deathSound;

	public void TakeDamage (int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			Die();
		}
	}

	void Die ()
	{
        FindObjectOfType<SoundLibrary>().PlayExplosion();
        Instantiate(drop, transform.position, Quaternion.identity);
        Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

}
