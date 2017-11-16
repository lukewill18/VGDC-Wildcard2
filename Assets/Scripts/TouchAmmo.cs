using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAmmo : MonoBehaviour 
{

    public int health = 1;
    public int ammo_amount;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            health--;
            if (health <= 0)
            {
                other.gameObject.GetComponentInChildren<GunController>().stored_ammunition += ammo_amount;
                other.gameObject.GetComponentInChildren<GunController>().ammo.text = other.gameObject.GetComponentInChildren<GunController>().ammunition.ToString() +  "/" + other.gameObject.GetComponentInChildren<GunController>().stored_ammunition.ToString();
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
