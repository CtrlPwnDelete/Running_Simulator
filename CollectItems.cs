using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollectItems : MonoBehaviour
{
	/// <summary>
	/// This allows the character to pick up items and increase score and highscore.
	/// </summary>
	
	
	private float highscore;
	private float score;
	GameObject player;

	public Text scoreText;
	public Text highscoreText;

	void Start () {
		UpdateScore ();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.name == "Apple") {
			score += 50;
			Destroy(other.gameObject);
		} 

		else if (other.name == "Blue Berry")
		{
			score += 100;
			Destroy(other.gameObject);
		}

		else if (other.name == "Banana")
		{
			score += 150;
			Destroy(other.gameObject);
		}

		else if (other.name == "Orange")
		{
			score += 200;
			Destroy(other.gameObject);
		}

		else if (other.name == "Peach")
		{
			score += 250;
			Destroy(other.gameObject);
		}

		else if (other.name == "Strawberry")
		{
			score += 300;
			Destroy(other.gameObject);
		}

		else if (other.name == "Corn")
		{
			score += 300;
			Destroy(other.gameObject);
		}

		else if (other.name == "Pommegranate")
		{
			score += 350;
			Destroy(other.gameObject);
		}
		UpdateScore (); 
	}

	void Update ()
	{
		if (score > highscore)
		{
			highscore = score;
		}

		Debug.Log (highscore);
	}

	void UpdateScore ()
	{
		scoreText.text = "Score: " + score;

		if (score > highscore)
		{
			highscore = score;
		}

		highscoreText.text = "High Score: " + highscore;
	}
}