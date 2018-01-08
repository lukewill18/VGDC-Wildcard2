﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMouse : MonoBehaviour {

    public float speed = 20f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 direction =  -Camera.main.ScreenToWorldPoint(Input.mousePosition) + transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 270, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime); 
	}


}
