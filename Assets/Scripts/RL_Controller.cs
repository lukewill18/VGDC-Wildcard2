using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RL_Controller : MonoBehaviour {

    public RocketController rocket;
    public float rocket_speed;

    public Text ammo;
    const int MAX_AMMO = 5;
    public int ammunition;
    public int stored_ammunition;
    public float timer, fireRate;
    string ammoDisplay;
    bool isReloading;

    public Transform fire_position;

    // Use this for initialization
    void Start () {
        ammo = GameObject.Find("Canvas/AmmoCounter").GetComponent<Text>();
        ammunition = MAX_AMMO;
        ammoDisplay = "/";
        fireRate = 0.1f;
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.R) && stored_ammunition > 0)
        {
            StartCoroutine(Reload());
        }

        if (Input.GetMouseButton(0) && ammunition > 0 && timer > fireRate && !isReloading)
        {
            ammunition--;
            RocketController newRocket = Instantiate(rocket, fire_position.position, fire_position.rotation);
            newRocket.speed = rocket_speed;
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ammo")
        {
            ammo.text = ammunition.ToString() + ammoDisplay + stored_ammunition;
        }
    }
}

