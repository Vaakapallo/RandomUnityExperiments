using UnityEngine;
using System.Collections;

public class EatScript : MonoBehaviour {

	public GameObject UIText;
	private PercentScript percent;
	private Transform lastTransform;

	
	// Use this for initialization
	void Start () {
		percent = UIText.GetComponent<PercentScript>();
		lastTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag.Equals("Wall")){
			percent.cubesEaten++;
			col.gameObject.SetActive(false);
			if(percent.cubesEaten % 10 == 0){
				GrowSnake();
			}
		}
	}

	void GrowSnake(){
		GameObject newTile = (GameObject)Instantiate (Resources.Load ("HingedSnakePart"));
		newTile.transform.position = lastTransform.position + Vector3.back * 0.9f;
		newTile.GetComponent<FollowScript>().toFollow = lastTransform.transform;
		lastTransform = newTile.transform;
	}
}
