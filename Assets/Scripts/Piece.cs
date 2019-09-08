using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
	public Material matBlue;
	public Material matRed;
	public Material matYellow;
	public Material matGreen;
	public SpawnPieces spawnPiece;
	private bool alreadyAttached = false;

	public BoxCollider upCollider;
	public BoxCollider downCollider;
	public BoxCollider leftCollider;
	public BoxCollider rightCollider;
	public SphereCollider detectionCollider;
	static int destroyBlue;
	static int destroyRed;
	static int destroyYellow;
	static int destroyGreen;



	PlayerMovement_Translation pm;

	[SerializeField]
	GameObject blueWall;
	[SerializeField]
	GameObject redWall;
	[SerializeField]
	GameObject yellowWall;
	[SerializeField]
	GameObject greenWall;

	// Start is called before the first frame update
	void Start()
	{
		pm = GetComponent<PlayerMovement_Translation>();

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

		blueWall = GameObject.Find("WallBlue");
		redWall = GameObject.Find("WallRed");
		yellowWall = GameObject.Find("WallYellow");
		greenWall = GameObject.Find("WallGreen");
	}

	private void Update()
	{

	}

	//Al chocar la pieza con otra pieza o con un borde del escenario
	private void OnTriggerEnter(Collider col)
	{
		if (alreadyAttached == false)
		{
			if (col.gameObject.CompareTag("blueWall"))

			{
				this.transform.parent = blueWall.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				spawnPiece.spawnPiecex();
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("redWall"))
			{
				this.transform.parent = redWall.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				spawnPiece.spawnPiecex();
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("yellowWall"))
			{
				this.transform.parent = yellowWall.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				spawnPiece.spawnPiecex();
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("greenWall"))
			{
				this.transform.parent = greenWall.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				spawnPiece.spawnPiecex();
				alreadyAttached = true;
			}

			/////////////////////////////////////////////////////////////////
			//Colision con piezas///////////////////////////////////////////
			///////////////////////////////////////////////////////////////

			else if (col.gameObject.CompareTag("bluePiece") || col.gameObject.CompareTag("bluePieces"))
			{
				this.transform.parent = col.gameObject.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				spawnPiece.spawnPiecex();
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("redPiece") || col.gameObject.CompareTag("redPieces"))
			{
				this.transform.parent = col.gameObject.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				spawnPiece.spawnPiecex();
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("yellowPiece") || col.gameObject.CompareTag("yellowPieces"))
			{
				this.transform.parent = col.gameObject.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				spawnPiece.spawnPiecex();
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("greenPiece") || col.gameObject.CompareTag("greenPieces"))
			{
				this.transform.parent = col.gameObject.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				spawnPiece.spawnPiecex();
				alreadyAttached = true;
			}
		}
	}

	private void OnTriggerStay(Collider col)
	{
		if (col.gameObject.CompareTag("destroyPieces"))
		{
			if (this.GetComponent<Renderer>().sharedMaterial == col.GetComponent<Renderer>().sharedMaterial)
			{
				this.gameObject.tag = "destroyPieces";
				DestroyPiecesWithTag();
			}
		}
		//En fila de 4 no lo hace - - cae -
		//							  esta cambia tag bluepiece por bluepieces junto a la de la derecha y se quedan las 4 con el tag bluepieces
		

		if (alreadyAttached==true)
		{
			if (this.CompareTag("bluePiece"))
			{				
				if (col.gameObject.CompareTag("bluePieces"))
				{
					this.gameObject.tag = "destroyPieces";
					col.gameObject.tag = "destroyPieces";
				}
				if (col.gameObject.CompareTag("bluePiece"))
				{
					this.gameObject.tag = "bluePieces";
					col.gameObject.tag = "bluePieces";
				}
			}

			if (this.CompareTag("redPiece")) 
			{
				if (col.gameObject.CompareTag("redPieces"))
				{
					this.gameObject.tag = "destroyPieces";
					col.gameObject.tag = "destroyPieces";
				}
				if (col.gameObject.CompareTag("redPiece"))
				{
					this.gameObject.tag = "redPieces";
					col.gameObject.tag = "redPieces";
				}				
			}

			if (this.CompareTag("yellowPiece"))
			{
				if (col.gameObject.CompareTag("yellowPieces"))
				{
					this.gameObject.tag = "destroyPieces";
					col.gameObject.tag = "destroyPieces";
				}
				if (col.gameObject.CompareTag("yellowPiece"))
				{
					this.gameObject.tag = "yellowPieces";
					col.gameObject.tag = "yellowPieces";
				}				
			}

			if (this.CompareTag("greenPiece")) 
			{				
				if (col.gameObject.CompareTag("greenPieces"))
				{
					this.gameObject.tag = "destroyPieces";
					col.gameObject.tag = "destroyPieces";
				}
				if (col.gameObject.CompareTag("greenPiece"))
				{
					this.gameObject.tag = "greenPieces";
					col.gameObject.tag = "greenPieces";
				}
			}
		}
	}

	void DestroyPiecesWithTag()
	{
		GameObject[] pieces = GameObject.FindGameObjectsWithTag("destroyPieces");
		for (int i = 0; i < pieces.Length; i++)
		{
			Destroy(pieces[i]);
		}
	}
}


