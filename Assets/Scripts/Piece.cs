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
	bool destroy = false;
	bool destroyBonus = false;

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

		float randomNumber = Random.Range(0f, 4f);		

		if ((randomNumber >= 0) && (randomNumber <= 1))
		{
			GetComponent<Renderer>().material = matBlue;
			this.gameObject.tag = "bluePiece";
		}

		else if ((randomNumber > 1) && (randomNumber <= 2))
		{
			GetComponent<Renderer>().material = matRed;
			this.gameObject.tag = "redPiece";
		}

		else if ((randomNumber > 2) && (randomNumber <= 3))
		{
			GetComponent<Renderer>().material = matYellow;
			this.gameObject.tag = "yellowPiece";
		}

		else if ((randomNumber > 3) && (randomNumber <= 4))
		{
			GetComponent<Renderer>().material = matGreen;
			this.gameObject.tag = "greenPiece";
		}

		blueWall = GameObject.Find("WallBlue");
		redWall = GameObject.Find("WallRed");
		yellowWall = GameObject.Find("WallYellow");
		greenWall = GameObject.Find("WallGreen");
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
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("redWall"))
			{
				this.transform.parent = redWall.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("yellowWall"))
			{
				this.transform.parent = yellowWall.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("greenWall"))
			{
				this.transform.parent = greenWall.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
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
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("redPiece") || col.gameObject.CompareTag("redPieces"))
			{
				this.transform.parent = col.gameObject.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("yellowPiece") || col.gameObject.CompareTag("yellowPieces"))
			{
				this.transform.parent = col.gameObject.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("greenPiece") || col.gameObject.CompareTag("greenPieces"))
			{
				this.transform.parent = col.gameObject.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
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

		else if (col.gameObject.CompareTag("destroyPiecesBonus"))
		{
			if (this.GetComponent<Renderer>().sharedMaterial == col.GetComponent<Renderer>().sharedMaterial)
			{
				this.gameObject.tag = "destroyPiecesBonus";
				StartCoroutine(WaitForDestroyBonus());
			}
		}

		else if (col.gameObject.CompareTag("startPoint"))
		{
			Time.timeScale = 0;
			GameOver.endgame = true;
		}

		if (alreadyAttached == true)
		{
			if (this.CompareTag("bluePiece"))
			{
				if (col.gameObject.CompareTag("bluePieces"))
				{
					if ((transform.parent.parent.tag == "blueWall") || (transform.parent.tag == "blueWall"))
					{
						this.gameObject.tag = "destroyPiecesBonus";
						col.gameObject.tag = "destroyPiecesBonus";
					}
					else
					{
						this.gameObject.tag = "destroyPieces";
						col.gameObject.tag = "destroyPieces";
					}
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
					if ((transform.parent.parent.tag == "redWall") || (transform.parent.tag == "redWall"))
					{
						this.gameObject.tag = "destroyPiecesBonus";
						col.gameObject.tag = "destroyPiecesBonus";
					}
					else
					{
						this.gameObject.tag = "destroyPieces";
						col.gameObject.tag = "destroyPieces";
					}
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
					if ((transform.parent.parent.tag == "yellowWall") || (transform.parent.tag == "yellowWall"))
					{
						this.gameObject.tag = "destroyPiecesBonus";
						col.gameObject.tag = "destroyPiecesBonus";
					}
					else
					{
						this.gameObject.tag = "destroyPieces";
						col.gameObject.tag = "destroyPieces";
					}
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
					if ((transform.parent.parent.tag == "greenWall") || (transform.parent.tag == "greenWall"))
					{
						this.gameObject.tag = "destroyPiecesBonus";
						col.gameObject.tag = "destroyPiecesBonus";
					}
					else
					{
						this.gameObject.tag = "destroyPieces";
						col.gameObject.tag = "destroyPieces";
					}
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
		yield return new WaitForSeconds(0.3f);
		destroy = true;
	}

	IEnumerator WaitForDestroyBonus()
	{
		yield return new WaitForSeconds(0.3f);
		destroyBonus = true;
	}

	private void FixedUpdate()
	{
		if (destroy == true)
		{
			DestroyPiecesWithTag();
			destroy = false;
		}

		if (destroyBonus == true)
		{
			DestroyPiecesWithTagBonus();
			destroyBonus = false;
		}
	}

	void DestroyPiecesWithTag()
	{
		GameObject[] pieces = GameObject.FindGameObjectsWithTag("destroyPieces");
		for (int i = 0; i < pieces.Length; i++)
		{
			if (pieces.Length == 3)
			{
				Score.points = Score.points + 100;
			}
			else if (pieces.Length == 4)
			{
				Score.points = Score.points + 125;
			}
			else if (pieces.Length == 5)
			{
				Score.points = Score.points + 150;
			}

			Destroy(pieces[i]);			
		}
	}

	void DestroyPiecesWithTagBonus()
	{
		GameObject[] pieces = GameObject.FindGameObjectsWithTag("destroyPiecesBonus");
		
		for (int i = 0; i < pieces.Length; i++)
		{
			if (pieces.Length == 3)
			{
				Score.points = Score.points + 150;
			}
			else if (pieces.Length == 4)
			{
				Score.points = Score.points + 175;
			}
			else if (pieces.Length == 5)
			{
				Score.points = Score.points + 200;
			}
			Destroy(pieces[i]);			
		}
	}	
}
