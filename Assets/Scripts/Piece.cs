using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
	private bool alreadyAttached = false;
	static int destroyBlue;
	static int destroyRed;
	static int destroyYellow;
	static int destroyGreen;
	static int contador;

	public Material matBlue;
	public Material matRed;
	public Material matYellow;
	public Material matGreen;
	public SpawnPieces spawnPiece;
	public BoxCollider upCollider;
	public BoxCollider downCollider;
	public BoxCollider leftCollider;
	public BoxCollider rightCollider;
	public SphereCollider detectionCollider;

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
				StartCoroutine(WaitForDestroy());
			}
		}
  
		if (alreadyAttached==true)
		{
			if (this.CompareTag("bluePiece"))
			{	
				if (col.gameObject.CompareTag("bluePieces"))
				{
					this.gameObject.tag = "destroyPieces";
					col.gameObject.tag = "destroyPieces";
					contador = 0;
				}
				else if ((col.gameObject.CompareTag("bluePiece")) && (contador >= 100))
				{
					this.gameObject.tag = "bluePieces";
					col.gameObject.tag = "bluePieces";
					contador = 0;
				}
			}

			if (this.CompareTag("redPiece")) 
			{
				if (col.gameObject.CompareTag("redPieces"))
				{
					this.gameObject.tag = "destroyPieces";
					col.gameObject.tag = "destroyPieces";
					contador = 0;
				}
				else if ((col.gameObject.CompareTag("redPiece")) && (contador >= 100))
				{
					this.gameObject.tag = "redPieces";
					col.gameObject.tag = "redPieces";
					contador = 0;
				}				
			}

			if (this.CompareTag("yellowPiece"))
			{
				if (col.gameObject.CompareTag("yellowPieces"))
				{
					this.gameObject.tag = "destroyPieces";
					col.gameObject.tag = "destroyPieces";
					contador = 0;
				}
				else if ((col.gameObject.CompareTag("yellowPiece")) && (contador >= 100))
				{
					this.gameObject.tag = "yellowPieces";
					col.gameObject.tag = "yellowPieces";
					contador = 0;
				}				
			}

			if (this.CompareTag("greenPiece")) 
			{				
				if (col.gameObject.CompareTag("greenPieces"))
				{
					this.gameObject.tag = "destroyPieces";
					col.gameObject.tag = "destroyPieces";
					contador = 0;
				}
				else if ((col.gameObject.CompareTag("greenPiece")) && (contador >= 100))
				{
					this.gameObject.tag = "greenPieces";
					col.gameObject.tag = "greenPieces";
					contador = 0;
				}
			}
		}

		//Contador checkea 100 veces para en caso de que haya múltiples colisiones se quede con la colision que tenga mayor tag
		contador++;
		
		if (contador >= 101)
		{
			contador = 0;
		}
	}

	IEnumerator WaitForDestroy()
	{
		yield return new WaitForSeconds(0.2f);
		DestroyPiecesWithTag();
	}

	void DestroyPiecesWithTag()
	{
		GameObject[] pieces = GameObject.FindGameObjectsWithTag("destroyPieces");
		for (int i = 0; i < pieces.Length; i++)
		{
			Destroy(pieces[i]);
			Score.points = Score.points + 100;
		}
	}
}


