using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchShotgunAmmo : MonoBehaviour {


	public int health = 1;
	public int ammo_amount;

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player") {
			health--;
			if (health <= 0) {
				other.gameObject.GetComponentInChildren<ShotgunScript> ().stored_ammunition += ammo_amount;
				other.gameObject.GetComponentInChildren<ShotgunScript> ().ammo.text = other.gameObject.GetComponentInChildren<ShotgunScript> ().ammunition.ToString () + "/" + other.gameObject.GetComponentInChildren<ShotgunScript> ().stored_ammunition.ToString ();
				Destroy (gameObject);
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
