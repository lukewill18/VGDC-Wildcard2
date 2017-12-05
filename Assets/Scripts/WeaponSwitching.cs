using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour {


	public int currentWeapon;
	public Transform[] weapons;
	public bool hasRifle = false;
	public bool hasShotgun = false;
	public bool hasSniper = false;
	public bool hasRocketLauncher = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			changeWeapon (0);
		}

		if (Input.GetKeyDown(KeyCode.Alpha2) && hasRifle)
		{
			changeWeapon (1);
		}

		if (Input.GetKeyDown(KeyCode.Alpha3) && hasShotgun)
		{
			changeWeapon (2);
		}

		if (Input.GetKeyDown(KeyCode.Alpha4) && hasSniper)
		{
			changeWeapon (3);
		}

		if (Input.GetKeyDown(KeyCode.Alpha5) && hasRocketLauncher)
		{
			changeWeapon (4);
		}
	}

	void changeWeapon(int num)
	{
		currentWeapon = num;
		for (int i = 0; i < weapons.Length; i++) {
			if (i == num) {
				weapons [i].gameObject.SetActive (true);
			} 
			else {
				weapons [i].gameObject.SetActive (false);
			}
		}
	}

}
