using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByEnemy : MonoBehaviour
{
    public static int health = 1;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Bile")
        {
            //Debug.Log("asdf");
            health--;

            if(health <=0)
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
