using UnityEngine;
using System.Collections;

public class SnakeManager : MonoBehaviour {

	public Transform lastTransform;

	// Use this for initialization
	void Start () {
		lastTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void GrowSnake(){
		GameObject newTile = (GameObject)Instantiate (Resources.Load ("HingedSnakePart"));
		newTile.transform.position = lastTransform.position + Vector3.back * 0.9f;
		newTile.GetComponent<FollowScript>().toFollow = lastTransform.transform;
		lastTransform = newTile.transform;
	}
}
