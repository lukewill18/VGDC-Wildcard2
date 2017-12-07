using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {

    public float spawn_delay = 3f; //time before 1st spawn

    public float spawn_time = 6f; // time between spawns

    public GameObject[] enemies;

    public int current_enemy = 0;

    public bool done_spawning = false;

	// Use this for initialization
	void Start () {

        InvokeRepeating("Spawn", spawn_delay, spawn_time);
    }
	
    void Spawn()
    {
        if(current_enemy <= enemies.Length)
        {
            Instantiate(enemies[current_enemy], transform.position, transform.rotation);
            current_enemy++;
        }
        else
        {
            done_spawning = true;
        }

    }

	// Update is called once per frame
	void Update () {
		
	}
}
