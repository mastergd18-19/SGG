using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBackground : MonoBehaviour
{
    // Start is called before the first frame update
    bool rotated = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        if (Input.GetKeyDown(KeyCode.D)&&(rotated==false))
        {
            transform.Rotate(Vector3.up * 90);
            //rotated = true;
        }

        if (Input.GetKeyDown(KeyCode.A)&&(rotated == false))
        {
            transform.Rotate(Vector3.down * 90);
            //rotated = true;
        }

        //SerializePrivateVariables void OnTriggerEnter2D(Collider)


    }
}
