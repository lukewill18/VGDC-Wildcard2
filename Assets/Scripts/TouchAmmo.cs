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
				if (other.gameObject.GetComponentInParent<WeaponSwitching>().currentWeapon == 0)
				{
					other.gameObject.GetComponentInChildren<PistolScript>().stored_ammunition += ammo_amount;
					other.gameObject.GetComponentInChildren<PistolScript>().ammo.text = other.gameObject.GetComponentInChildren<PistolScript>().ammunition.ToString() +  "/" + other.gameObject.GetComponentInChildren<PistolScript>().stored_ammunition.ToString();
	                Destroy(gameObject);
				}
				else if (other.gameObject.GetComponentInParent<WeaponSwitching>().currentWeapon == 1)
				{
					other.gameObject.GetComponentInChildren<GunController>().stored_ammunition += ammo_amount;
					other.gameObject.GetComponentInChildren<GunController>().ammo.text = other.gameObject.GetComponentInChildren<GunController>().ammunition.ToString() +  "/" + other.gameObject.GetComponentInChildren<GunController>().stored_ammunition.ToString();
					Destroy(gameObject);
				}
				else if (other.gameObject.GetComponentInParent<WeaponSwitching>().currentWeapon == 2)
				{
					other.gameObject.GetComponentInChildren<ShotgunScript>().stored_ammunition += ammo_amount;
					other.gameObject.GetComponentInChildren<ShotgunScript>().ammo.text = other.gameObject.GetComponentInChildren<ShotgunScript>().ammunition.ToString() +  "/" + other.gameObject.GetComponentInChildren<ShotgunScript>().stored_ammunition.ToString();
					Destroy(gameObject);
				}
				else if (other.gameObject.GetComponentInParent<WeaponSwitching>().currentWeapon == 3)
				{
					other.gameObject.GetComponentInChildren<SniperScript>().stored_ammunition += ammo_amount;
					other.gameObject.GetComponentInChildren<SniperScript>().ammo.text = other.gameObject.GetComponentInChildren<SniperScript>().ammunition.ToString() +  "/" + other.gameObject.GetComponentInChildren<SniperScript>().stored_ammunition.ToString();
					Destroy(gameObject);
				}
				else if (other.gameObject.GetComponentInParent<WeaponSwitching>().currentWeapon == 4)
				{
					other.gameObject.GetComponentInChildren<RL_Controller>().stored_ammunition += ammo_amount;
					other.gameObject.GetComponentInChildren<RL_Controller>().ammo.text = other.gameObject.GetComponentInChildren<RL_Controller>().ammunition.ToString() +  "/" + other.gameObject.GetComponentInChildren<RL_Controller>().stored_ammunition.ToString();
					Destroy(gameObject);
				}
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
