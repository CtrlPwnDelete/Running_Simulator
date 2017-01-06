using UnityEngine;
using System.Collections;

public class CollectItems : MonoBehaviour
{
	/// <summary>
	/// This allows the character to pick up items and increase score and highscore.
	/// </summary>


	public int highscore = 0;
	public int score = 0;
	GameObject player;

	void OnTriggerEnter(Collider other){
		Destroy(other.gameObject);
	}

	//This method sees if the player collides with a Fruit and if it does, it will change the score
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "Fruit") {
			score += 50;
		}
		if (col.gameObject.name == "Fruit") {
			score += 100;
		}
		if (col.gameObject.name == "Fruit") {
			score += 250;
		}
	}

	//this method updates the highscore if the players score is higher than the high score
	public void updateHighscore ()
	{
		if (score > highscore) {
			highscore = score;
		}
	}

	void Update ()
	{
		updateHighscore ();
		Debug.Log (score);

	}




}