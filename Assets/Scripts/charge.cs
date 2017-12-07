using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charge : MonoBehaviour {

    public GameObject target;
    public float speed = .15f;

    public float charge_delay = 2f;

    public float time_between_charges = 4f;

    private bool charging = false;

    public bool seen;

    private Vector3 v_diff;
    private float atan2;

    public Vector3 charge_position;
    // Use this for initialization
    void Start () {
        if (GameObject.FindWithTag("Player") != null)
        {
            InvokeRepeating("charge_player", charge_delay, time_between_charges);
        }
    }
	
    void OnBecameVisible()
    {
        seen = true;
    }

    void OnBecameInvisible()
    {
        seen = false;
    }

    // Update is called once per frame
    void charge_player () {
        if (GameObject.FindWithTag("Player") != null)
        {
            target = GameObject.FindWithTag("Player");
			if (!Physics.Raycast(transform.position, target.transform.position) && seen)
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
            v_diff = (charge_position - transform.position);
            atan2 = Mathf.Atan2(v_diff.y, v_diff.x);
            transform.rotation = Quaternion.Euler(0f, 0f, atan2 * Mathf.Rad2Deg);
            transform.position = Vector3.MoveTowards(transform.position, charge_position, speed);

        }

    }

}
