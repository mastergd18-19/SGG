using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_Physics : MonoBehaviour
{
    // Start is called before the first frame update
    public float acceleration;
    public float deceleration;
    public bool moving;


    private Rigidbody rb;
    public float rR=1;
    public float t=1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("CheckSpeed", t, rR);
    }

    void Movement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * acceleration);

        if (Input.GetAxis("Horizontal") != 0.0f | Input.GetAxis("Vertical") != 0.0f)
        {
            moving = true;
        }
        else
        {
            moving = false;
        }
    }

    void MovementDeceleration()
    {
        if (moving == false)
        {
            rb.angularDrag = deceleration;
        }
        else
        {
            rb.angularDrag = 0.05f;
        }
    }

    void Update()
    {
        Movement();
        MovementDeceleration();
    }

    void CheckSpeed()
    {
        Debug.Log("Velocidad en x: " + rb.velocity.x);
        Debug.Log("Velocidad en y: " + rb.velocity.y);
        Debug.Log("Velocidad en z: " + rb.velocity.z);
    }
 }

