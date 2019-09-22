using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
	public Canvas canvasObject;
	public GameObject score;
	public AudioSource gameOverSound;
	public AudioSource song;
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
		song.enabled = false;
		gameOverSound.enabled = true;
		canvasObject.enabled = true;
		score.SetActive(false);		
	}
}
