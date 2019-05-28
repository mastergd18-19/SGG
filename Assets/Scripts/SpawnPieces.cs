using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPieces : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myPiece;
    void Start()
    {
        Instantiate(myPiece, this.gameObject.GetComponent<Transform>().position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
