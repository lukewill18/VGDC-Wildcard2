using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour {

	public string weapon_check;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player") {
			if (weapon_check == "Rifle") {
				other.gameObject.GetComponent<WeaponSwitching> ().hasRifle = true;
				Destroy (gameObject);
			}
			else if (weapon_check == "Shotgun") {
				other.gameObject.GetComponent<WeaponSwitching> ().hasShotgun = true;
				Destroy (gameObject);
			}
			else if (weapon_check == "Sniper") {
				other.gameObject.GetComponent<WeaponSwitching> ().hasSniper = true;
				Destroy (gameObject);
			}
			else if (weapon_check == "RocketLauncher") {
				other.gameObject.GetComponent<WeaponSwitching> ().hasRocketLauncher = true;
				Destroy (gameObject);
			}

		}
	}
}

