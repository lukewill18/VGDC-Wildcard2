using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieShotController : MonoBehaviour {

    public float speed = 2f;

    public float lifeTime = 3f;

    public Vector3 target;

    public Vector3 spawn_position;

    public bool passed_target = false;

    // Use this for initialization
    void Start () {

        spawn_position = transform.position;

        if (GameObject.FindWithTag("Player") != null)
        {
            target = GameObject.FindWithTag("Player").transform.position;
        }

    }
	
	// Update is called once per frame
	void Update () {

        if(transform.position == target)
        {
            passed_target = true;
        }

        if (!passed_target)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, spawn_position, -speed * Time.deltaTime);
        }
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
