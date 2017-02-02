using UnityEngine;
using System.Collections;
using System.Timers;

public class TileGeneration : MonoBehaviour {
	
	public GameObject C;
	public GameObject L;
	public GameObject R;

	public GameObject[] tilePrefabs;
	int number;
	Vector3 oldPosition;

	// Use this for initialization
	void Start () 
	{
		oldPosition = new Vector3 (0, 0.5f, -3.31f);

	}

	public void SpawnTile()
	{
		number = Random.Range (0,3);


		if(number == 0)
		{

		tilePrefabs[number] = (GameObject)Instantiate(tilePrefabs[number], oldPosition, Quaternion.identity);
	
		}

		if(number == 1)
		{

			tilePrefabs[number] = (GameObject)Instantiate(tilePrefabs[number], oldPosition, Quaternion.identity);

				
		}
		if(number == 2)
		{
			
			tilePrefabs[number] = (GameObject)Instantiate(tilePrefabs[number], oldPosition, Quaternion.identity);
		
		}

		oldPosition = new Vector3 (oldPosition.x, oldPosition.y, oldPosition.z + 4.5f); 

	}
	




	
	// Update is called once per frame
	void Update () {

		SpawnTile();

	}
}
