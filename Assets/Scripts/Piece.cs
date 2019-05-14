using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandomColor : MonoBehaviour
{
    public Material matBlue;
    public Material matRed;
    public Material matYellow;
    public Material matGreen;

    // Start is called before the first frame update
    void Start()
    {
        int randomNumber = Random.Range(1, 4);

        if (randomNumber == 1)
        {
            GetComponent<Renderer>().material = matBlue;
            this.gameObject.tag = "bluePiece";
        }

        else if (randomNumber == 2)
        {
            GetComponent<Renderer>().material = matRed;
            this.gameObject.tag = "redPiece";
        }

        else if (randomNumber == 3)
        {
            GetComponent<Renderer>().material = matYellow;
            this.gameObject.tag = "yellowPiece";
        }

        else
        {
            GetComponent<Renderer>().material = matGreen;
            this.gameObject.tag = "greenPiece";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("blueWall"))
        {
            Debug.Log("BLUE");
            //this.transform.position 
        }

        else if (col.gameObject.CompareTag("redWall"))
        {
            Debug.Log("RED");
        }

        else if (col.gameObject.CompareTag("yellowWall"))
        {
            Debug.Log("YELL");
        }

        else if (col.gameObject.CompareTag("greenWall"))
        {
            Debug.Log("GREE");
        }
    }
}
