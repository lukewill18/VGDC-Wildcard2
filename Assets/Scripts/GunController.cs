using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {


    public bool isFiring;
    public BulletController bullet;
    public float bullet_speed;

    public float timeBetweenShots;
    private float shotCounter;

    public Transform fire_position;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenShots;
                BulletController newBullet = Instantiate(bullet, fire_position.position, fire_position.rotation);
                newBullet.speed = bullet_speed;
            }
        }
        else
        {
            shotCounter = 0;
        }

        /*
        if (Input.GetMouseButtonDown(0)
        {
            isFiring = true;
        }
        else
        {
            isFiring = false;
        }
        */
	}
}
