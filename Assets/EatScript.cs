using UnityEngine;
using System.Collections;

public class EatScript : MonoBehaviour {

	public GameObject UIText;
	private PercentScript percent;
	private Transform lastTransform;
	private Color[] colors = {Color.red, Color.black};
	private Color lerped = Color.red;
	private float lerpProgress = 0.04f;
	private int choice = 1;
	
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
		lerped = Color.Lerp (lerped, colors [choice], lerpProgress);
		newTile.GetComponentInChildren<Renderer>().material.color = lerped;
		if (sameColor(lerped, colors[choice])) {
			choice++;
			if(choice >= colors.Length){
				choice = 0;
			}
		}
		lastTransform = newTile.transform;
	}

	bool closeEnough(float first, float second){
		if(first <= second + 0.1f && first >= second - 0.1f){
			return true;
		}
		return false;
	}
	
	bool sameColor(Color color1, Color color2){
		if(closeEnough(color1.b,color2.b)){
			if(closeEnough(color1.r,color2.r)){
				if(closeEnough(color1.g,color2.g)){
					return true;
				}
			}
		}
		
		return false;
	}
}
