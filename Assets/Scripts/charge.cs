using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charge : MonoBehaviour {

    public GameObject target;
    public float speed = .35f;

    public float charge_delay = 1f;

    public float time_between_charges = 4f;

    private bool charging = false;

    public Vector3 charge_position;
    // Use this for initialization
    void Start () {
        if (GameObject.FindWithTag("Player") != null)
        {
            InvokeRepeating("charge_player", charge_delay, time_between_charges);
        }
    }
	
	// Update is called once per frame
	void charge_player () {
        if (GameObject.FindWithTag("Player") != null)
        {
            target = GameObject.FindWithTag("Player");
            if (!Physics.Raycast(transform.position, target.transform.position))
            {
                charging = true;
                charge_position = target.transform.position;
                //charge to player's position
            }
        }
    }

    void Update()
    {
        if(charging)
        {
            transform.position = Vector3.MoveTowards(transform.position, charge_position, speed);

        }

    }

}
