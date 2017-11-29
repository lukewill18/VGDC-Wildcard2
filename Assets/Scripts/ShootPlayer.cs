using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour {

    public GameObject target;

    public GameObject shot;

    public float shot_delay = 1f;

    public float time_between_shots = 3f;

	// Use this for initialization
	void Start () {
        if (GameObject.FindWithTag("Player") != null)
        {
            InvokeRepeating("shoot_player", shot_delay, time_between_shots);
        }

    }

    void shoot_player()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            target = GameObject.FindWithTag("Player");
            //transform.LookAt(target.transform);
            Instantiate(shot, transform.position, transform.rotation);
            
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
