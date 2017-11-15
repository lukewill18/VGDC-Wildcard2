using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAmmo : MonoBehaviour {

    public int health = 1;
    public int ammo_amount;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            health--;

            if (health < 0)
            {
                other.gameObject.GetComponent<GunController>().stored_ammunition += ammo_amount;
                Destroy(gameObject);
            }
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
