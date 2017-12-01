using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotgunScript : MonoBehaviour
{
	public int shotFragments = 3;
	public float spreadangle = 10.0f;
	public BulletController bullet;
	public float bullet_speed;

	public Text ammo;
	public int MAX_AMMO = 5;
	public int ammunition;
	public int stored_ammunition;
	public float timer, fireRate;
	public string ammoDisplay;
	bool isReloading;
	public Transform fire_position;



	private void shoot_and_reload()
	{
		timer += Time.deltaTime;
		print (fire_position.rotation.eulerAngles.z);
		if (Input.GetKeyDown(KeyCode.R) && stored_ammunition > 0)
		{
			StartCoroutine(Reload());
		}
		if (Input.GetMouseButtonDown(0) && ammunition > 0 && timer > fireRate && !isReloading)
		{
			ammunition--;
			BulletController newBullet1 = Instantiate(bullet, fire_position.position, (Quaternion.Euler(new Vector3(0,0,315+fire_position.rotation.eulerAngles.z))));
			Debug.Log (newBullet1.transform.rotation);
			BulletController newBullet2 = Instantiate(bullet, fire_position.position, fire_position.rotation);
			BulletController newBullet3 = Instantiate(bullet, fire_position.position, Quaternion.Euler(new Vector3(0,0,45+fire_position.rotation.eulerAngles.z)));
			Debug.Log (newBullet3.transform.rotation);

			newBullet1.speed = bullet_speed;
			newBullet2.speed = bullet_speed;
			newBullet3.speed = bullet_speed;
			ammo.text = ammunition.ToString() + ammoDisplay + stored_ammunition;
			timer = 0;
		}
	}
		
	IEnumerator Reload()
	{
		isReloading = true;
		yield return new WaitForSeconds(1);
		if (stored_ammunition + ammunition >= MAX_AMMO && stored_ammunition > 0)
		{
			stored_ammunition = ammunition + stored_ammunition - MAX_AMMO;
			ammunition = MAX_AMMO;
		}
		else
		{
			ammunition = stored_ammunition + ammunition;
			stored_ammunition = 0;
		}
		ammo.text = ammunition.ToString() + ammoDisplay + stored_ammunition.ToString();
		isReloading = false;
	}

	// Use this for initialization
	void Start ()
	{
		ammo = GameObject.Find("Canvas/AmmoCounter").GetComponent<Text>();
		ammunition = MAX_AMMO;
		ammoDisplay = "/";
		ammo.text = ammunition.ToString() + ammoDisplay + stored_ammunition.ToString();
		fireRate = 0.5f;
	}
	
	// Update is called once per frame
	void Update ()
	{

		shoot_and_reload ();
	}
		
}

