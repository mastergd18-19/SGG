using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
	public TextMeshProUGUI scoreText;
	private AudioSource pieceDestructionSound;
	public static int points;
	public static bool sound = false;

	private void Start()
	{
		pieceDestructionSound = GetComponent<AudioSource>();
		points = 0;
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
