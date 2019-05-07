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
            
        }

        else if (randomNumber == 2)
        {
            GetComponent<Renderer>().material = matRed;
        }

        else if (randomNumber == 3)
        {
            GetComponent<Renderer>().material = matYellow;
        }

        else
        {
            GetComponent<Renderer>().material = matGreen;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
