using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDisappear : MonoBehaviour
{
    public int health = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //Debug.Log("asdf");
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
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
