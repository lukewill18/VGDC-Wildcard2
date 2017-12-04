using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SniperScript : MonoBehaviour {



	public BulletController bullet;
	public float bullet_speed;

	public Text ammo;
	public int MAX_AMMO;
	public int ammunition;
	public int stored_ammunition;
	public float timer, fireRate;
	public string ammoDisplay;
	bool isReloading;


	public Transform fire_position;

	// Use this for initialization
	void Start () {
		ammo = GameObject.Find("Canvas/AmmoCounter").GetComponent<Text>();
		ammunition = MAX_AMMO;
		ammoDisplay = "/";
		fireRate = .1f;
	}

	// Update is called once per frame
	void Update () {

		shoot_and_reload();
		ammo.text = ammunition.ToString() + ammoDisplay + stored_ammunition.ToString();

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

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Ammo")
		{
			ammo.text = ammunition.ToString() + ammoDisplay + stored_ammunition;
		}
	}

	protected virtual void shoot_and_reload() 
	{
		timer += Time.deltaTime;

		if (Input.GetKeyDown(KeyCode.R) && stored_ammunition > 0)
		{
			StartCoroutine(Reload());
		}

		if (Input.GetMouseButtonDown(0) && ammunition > 0 && timer > fireRate && !isReloading)
		{
			ammunition--;
			BulletController newBullet = Instantiate(bullet, fire_position.position, fire_position.rotation);
			newBullet.speed = bullet_speed;
			ammo.text = ammunition.ToString() + ammoDisplay + stored_ammunition;
			timer = 0;
		}
	}
}
