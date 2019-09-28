using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
	public Canvas canvasObject;
	public GameObject score;
	public AudioSource gameOverSound;
	public AudioSource song;
	public static bool endgame = false;
	private bool enableBack = false;

	public void Update()
	{
		if ((Input.GetKeyDown(KeyCode.Escape)))
		{
			reloadMenu();
		}

		if (endgame == true)
		{
			endGame();
		}

		if (enableBack == true)
		{
			if ((Input.GetKeyDown(KeyCode.Space)))
			{
				reloadMenu();
			}
		}
	}

	public void endGame()
	{
		song.enabled = false;
		gameOverSound.enabled = true;
		canvasObject.enabled = true;
		score.SetActive(false);
		enableBack = true;
		endgame = false;
	}

	void reloadMenu()
	{
		SceneManager.LoadScene("Menu");
	}
}
