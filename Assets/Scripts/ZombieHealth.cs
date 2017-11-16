using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour {

    public int health = 3;

	// Use this for initialization
	void Start () {
        health = 3;
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            health--;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
            // Update is called once per frame
            void Update () {
		
	}
}
