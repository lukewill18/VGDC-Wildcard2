using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{

    public float speed = 3f;

    public float lifeTime = 4f;

    public int damage_given = 5;

    public GameObject blast;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0, 1) * speed * Time.deltaTime);

        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            explode();
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        explode();
    }

    void explode()
    {
        Destroy(gameObject);
        Instantiate(blast, transform.position, transform.rotation);
    }
}
