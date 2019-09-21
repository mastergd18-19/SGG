using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
	public Canvas canvasObject;
	public GameObject score;

	public static bool endgame=false;

	public void Update()
	{
		if (endgame == true)
		{
			endGame();
		}
	}

	public void endGame()
	{
		canvasObject.enabled = true;
		score.SetActive(false);
	}
}
