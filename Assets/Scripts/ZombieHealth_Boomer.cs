using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth_Boomer : MonoBehaviour
{

    public int health = 3;

    public GameObject bile;

    // Use this for initialization
    void Start()
    {
        health = 3;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            health--;
            if (health <= 0)
            {
                Die();
            }
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Instantiate(bile, transform.position, transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
