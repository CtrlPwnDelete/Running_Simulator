using UnityEngine;
using System.Collections;

public class TileGeneration : MonoBehaviour {
	
	public GameObject C;

	public GameObject[] tilePrefabs;
	int i = 0;
	bool test = true;
	// Use this for initialization
	void Start () {
		

	}

	public void SpawnTile()
	{
		for(i = 0; i < 1; i++)
		{
			C = (GameObject)Instantiate(tilePrefabs[0], C.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);

		}

	}






	
	// Update is called once per frame
	void Update () {
		SpawnTile();
	}
}
