using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour {
	/// <summary>
	/// This makes the player die and can tell what way he had died in (falls to death/killed by combine) and can cause the player to lose.
	/// </summary>

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "Combine") {
			//make death screen for death by combine pop up
			Time.timeScale = 0;
		}
		if (col.gameObject.name == "Wall") {
			//make death screen for death by turning into a wall pop up
			Time.timeScale = 0;
		}
		if (col.gameObject.name == "Floor") {
			//make death screen for death by falling into a hole pop up
			Time.timeScale = 0;
		}

	}
	void Update () {
	
	}
}
