using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GridScript : MonoBehaviour {

	public GameObject wallPiece;
	private List<GameObject> pieces = new List<GameObject>();
	
	// Use this for initialization
	void Start () {
		for (float i = 0f; i < 21; i++) {
			for (float j = 0f; j < 2; j++) {
				GameObject newTile = (GameObject)Instantiate(wallPiece, transform.position + new Vector3(i*2f,j*11.5f,0), Quaternion.identity);
				newTile.transform.parent = transform;
				pieces.Add(newTile);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
