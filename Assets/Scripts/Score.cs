using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Text scoreText;
	private AudioSource pieceDestructionSound;
	public static int points;
	public static bool sound = false;

	private void Start()
	{
		pieceDestructionSound = GetComponent<AudioSource>();
	}
	
	void Update()
    {
		scoreText.text = points.ToString();

		if (sound == true)
		{			
			pieceDestructionSound.Play();			
			sound = false;
		}
	}
}
