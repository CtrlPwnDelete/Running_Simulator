
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DestroyTiles : MonoBehaviour
{
	/// <summary>
	/// This allows the tiles to be destroyed.
	/// </summary>


	void Start () {
	}
	void OnCollisionEnter(Collision other)
	{
		Debug.Log (other);
		if (other.gameObject.tag == "Tile") {
			Destroy(other.gameObject);

		} 
	
	}

}