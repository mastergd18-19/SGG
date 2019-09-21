using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPieces : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject myPiece;
	public Piece pieceCollisions;
	public PlayerMovement_Translation movement;
	int randomNumber;
	int randomNumber2;
	float repeat=0.5f;

	void Start()
	{
		spawnPiecex();		
	}

	public void spawnPiecex()
	{
		if (repeat > 2.0f)
		{
			repeat = repeat - 0.05f;
		}

		Invoke("spawnPiecex", repeat);

		randomNumber = Random.Range(1, 12);
		randomNumber2 = Random.Range(1, 2);

		pieceCollisions.downCollider.enabled = false;
		pieceCollisions.upCollider.enabled = false;
		pieceCollisions.leftCollider.enabled = false;
		pieceCollisions.rightCollider.enabled = false;
		
		//1=DOWN, 2=UP, 3=LEFT, 4=RIGHT
		if (randomNumber == 1)
		{
			if (randomNumber2 == 1)
			{
				movement.direction = 2;
				pieceCollisions.upCollider.enabled = true;
			}
			else
			{
				movement.direction = 3;
				pieceCollisions.leftCollider.enabled = true;
			}
			Instantiate(myPiece, new Vector3(-1.5f, 0, 1.5f), Quaternion.identity);
		}
		else if (randomNumber == 2)
		{
			movement.direction = 2;
			pieceCollisions.upCollider.enabled = true;
			Instantiate(myPiece, new Vector3(-0.5f, 0, 1.5f), Quaternion.identity);
		}
		else if (randomNumber == 3)
		{
			movement.direction = 2;
			pieceCollisions.upCollider.enabled = true;
			Instantiate(myPiece, new Vector3(0.5f, 0, 1.5f), Quaternion.identity);			
		}
		else if (randomNumber == 4)
		{			
			if (randomNumber2 == 1)
			{
				movement.direction = 2;
				pieceCollisions.upCollider.enabled = true;
			}
			else
			{
				movement.direction = 4;
				pieceCollisions.rightCollider.enabled = true;
			}
			Instantiate(myPiece, new Vector3(1.5f, 0, 1.5f), Quaternion.identity);
		}
		else if (randomNumber == 5)
		{
			movement.direction = 4;
			pieceCollisions.rightCollider.enabled = true;
			Instantiate(myPiece, new Vector3(1.5f, 0, 0.5f), Quaternion.identity);				
		}
		else if (randomNumber == 6)
		{
			movement.direction = 4;
			pieceCollisions.rightCollider.enabled = true;
			Instantiate(myPiece, new Vector3(1.5f, 0, -0.5f), Quaternion.identity);			
		}
		else if (randomNumber == 7)
		{
			if (randomNumber2 == 1)
			{				
				movement.direction = 1;
				pieceCollisions.downCollider.enabled = true;
			}
			else
			{
				movement.direction = 4;
				pieceCollisions.rightCollider.enabled = true;
			}
			Instantiate(myPiece, new Vector3(1.5f, 0, -1.5f), Quaternion.identity);
		}
		else if (randomNumber == 8)
		{
			movement.direction = 1;
			pieceCollisions.downCollider.enabled = true;
			Instantiate(myPiece, new Vector3(0.5f, 0, -1.5f), Quaternion.identity);
		}
		else if (randomNumber == 9)
		{
			movement.direction = 1;
			pieceCollisions.downCollider.enabled = true;
			Instantiate(myPiece, new Vector3(-0.5f, 0, -1.5f), Quaternion.identity);
		}
		else if (randomNumber == 10)
		{
			if (randomNumber2 == 1)
			{
				movement.direction = 1;
				pieceCollisions.downCollider.enabled = true;
			}
			else
			{
				movement.direction = 3;
				pieceCollisions.leftCollider.enabled = true;
			}
			Instantiate(myPiece, new Vector3(-1.5f, 0, -1.5f), Quaternion.identity);
		}
		else if (randomNumber == 11)
		{
			movement.direction = 3;
			pieceCollisions.leftCollider.enabled = true;
			Instantiate(myPiece, new Vector3(-1.5f, 0, -0.5f), Quaternion.identity);
		}
		else if (randomNumber == 12)
		{
			movement.direction = 3;
			pieceCollisions.leftCollider.enabled = true;
			Instantiate(myPiece, new Vector3(-1.5f, 0, 0.5f), Quaternion.identity);
		}				
	}
}
