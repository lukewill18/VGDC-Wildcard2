using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

    public Transform target;
    public float speed = .01f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.LookAt(target.position);

        if (Vector3.Distance(transform.position, target.position) > 1)
        {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
        }

    }
}
