using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    public int health;
    private int current_health;

	// Use this for initialization
	void Start () {
        current_health = health;
	}
	
	// Update is called once per frame
	void Update () {
		if (current_health <= 0)
        {
            Destroy(gameObject);
        }
	}


    public void HurtEnemy(int damage)
    {
        current_health -= damage;
    }
}
