using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{

    public float moveSpeed;
    private Rigidbody2D myRigidbody;

    private Vector2 moveInput;
    private Vector2 moveVelocity;

    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"),  Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * moveSpeed;

        if (Input.GetAxisRaw("Horizontal") >= 1 && Input.GetAxisRaw("Vertical") >= 1)
        {
            Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal") / 2, Input.GetAxisRaw("Vertical") / 2);
        }
    }

    void FixedUpdate() {
        myRigidbody.velocity = moveVelocity;
    }
}   