using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour {


	public int currentWeapon;
	public Transform[] weapons;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			changeWeapon (0);
		}

		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			changeWeapon (1);
		}

		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			changeWeapon (2);
		}

		if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			changeWeapon (3);
		}

		if (Input.GetKeyDown(KeyCode.Alpha5))
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
