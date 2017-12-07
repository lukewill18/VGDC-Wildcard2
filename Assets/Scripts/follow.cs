using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

    public Transform target;
    public float speed = .01f;

    private Vector3 v_diff;
    private float atan2;

    // Use this for initialization
    void Start () {
        if(GameObject.FindWithTag("Player") != null)
        {
            target = GameObject.FindWithTag("Player").transform;
        }
    }
	
	// Update is called once per frame
	void Update () {
        v_diff = (target.position - transform.position);
        atan2 = Mathf.Atan2(v_diff.y, v_diff.x);
        transform.rotation = Quaternion.Euler(0f, 0f, atan2 * Mathf.Rad2Deg);

        if (target != null) //need to detect if player has died 
        {
            if (!Physics.Raycast(transform.position, target.position))
            {
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
            }
        }

    }
}
