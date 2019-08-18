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

	private void OnTriggerEnter(Collider col)
	{
		if (alreadyAttached == false)
		{
			if (col.gameObject.CompareTag("blueWall"))

			{
				//Debug.Log("BLUE");
				this.transform.parent = blueWall.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				spawnPiece.spawnPiecex();
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("redWall"))
			{
				//Debug.Log("RED");
				this.transform.parent = redWall.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				spawnPiece.spawnPiecex();
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("yellowWall"))
			{
				//Debug.Log("YELLOW");
				this.transform.parent = yellowWall.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				spawnPiece.spawnPiecex();
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("greenWall"))
			{
				//Debug.Log("GREEN");
				this.transform.parent = greenWall.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				spawnPiece.spawnPiecex();
				alreadyAttached = true;
			}

			//Colision con piezas

			else if (col.gameObject.CompareTag("bluePiece"))
			{
				Debug.Log("BLUEPiece");
				this.transform.parent = blueWall.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				spawnPiece.spawnPiecex();
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("redPiece"))
			{
				Debug.Log("REDpiece");
				this.transform.parent = blueWall.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				spawnPiece.spawnPiecex();
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("yellowPiece"))
			{
				Debug.Log("YELLOWpiece");				
				this.transform.parent = blueWall.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				spawnPiece.spawnPiecex();
				alreadyAttached = true;
			}

			else if (col.gameObject.CompareTag("greenPiece"))
			{
				Debug.Log("GREENpiece");				
				this.transform.parent = blueWall.transform;
				pm.CancelInvoke();
				detectionCollider.enabled = true;
				spawnPiece.spawnPiecex();
				alreadyAttached = true;
			}
		}
	}
}
