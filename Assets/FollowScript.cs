using UnityEngine;
using System.Collections;

public class FollowScript : MonoBehaviour {

	public Transform toFollow;
	private float distance = 0.9f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (toFollow.position);
		transform.position = (transform.position - toFollow.transform.position).normalized * distance + toFollow.transform.position;	
	}

	public void setFollow(Transform transform){
		toFollow = transform;
		print ("stuff");
	}
}
