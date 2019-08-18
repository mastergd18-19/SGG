using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_Translation : MonoBehaviour
{
    public float speed;
    public bool moving;
    public float rR = 0.5f;
    public float t = 0.5f;
	public int direction;

    // Start is called before the first frame update
    void Start()
    {
		if (direction == 2)
		{
			InvokeRepeating("MovementUp", t, rR);
		}

		else if (direction == 3)
		{
			InvokeRepeating("MovementLeft", t, rR);
		}

		else if (direction == 4)
		{
			InvokeRepeating("MovementRight", t, rR);
		}
		else
		{
			InvokeRepeating("MovementBack", t, rR);
		}			
	}

    void MovementBack()
    {		
		transform.position += Vector3.back;
	}

	void MovementUp()
	{
		transform.position += Vector3.forward;
	}

	void MovementLeft()
	{
		transform.position += Vector3.left;
	}

	void MovementRight()
	{
		transform.position += Vector3.right;
	}	
}
