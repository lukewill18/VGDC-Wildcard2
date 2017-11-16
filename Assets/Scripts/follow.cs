using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

    public Transform target;
    public float speed = .01f;
  
	// Use this for initialization
	void Start () {
        if(GameObject.FindWithTag("Player") != null)
        {
            target = GameObject.FindWithTag("Player").transform;
        }
    }
	
	// Update is called once per frame
	void Update () {
        //transform.LookAt(target.position);
        if (target != null) //need to detect if player has died 
        {
            Debug.Log("asdf");
            if (!Physics.Raycast(transform.position, target.position))
            {
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
            }
        }

    }
}
