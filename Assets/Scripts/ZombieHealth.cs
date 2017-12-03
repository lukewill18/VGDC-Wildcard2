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
		if (other.gameObject.tag == "Projectile") {
			health = health - other.gameObject.GetComponent<BulletController> ().damage_given;
		} else if (other.gameObject.tag == "Rocket") {
			health = health - 3;
		} else if (other.gameObject.tag == "SniperProjectile") {
			Physics2D.IgnoreCollision (other.gameObject.GetComponent<Collider2D>(), this.GetComponent<Collider2D>());
			health = health - other.gameObject.GetComponent<BulletController> ().damage_given;
		}

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
            // Update is called once per frame
            void Update () {
		
	}
}
