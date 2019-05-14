using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_Translation : MonoBehaviour
{
    public float speed;
    public bool moving;
    public float rR = 1;
    public float t = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Movement", t, rR);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Movement()
    {

        transform.position += Vector3.back;

        //float moveHorizontal = Input.GetAxisRaw("Horizontal");
        //float moveVertical = Input.GetAxisRaw("Vertical");

        //if (Input.GetKey(KeyCode.W))
        //{

        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(Vector3.back * speed * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(Vector3.right * speed * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(Vector3.left * speed * Time.deltaTime);
        //}

    }
}
