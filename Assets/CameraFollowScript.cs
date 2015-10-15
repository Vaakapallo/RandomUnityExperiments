using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour {


	public GameObject snakeHead;
	public float forwardValue = 10.0f;
	public float dampStrength = 0.05f;
	public float upMultiplier = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 velocity = Vector3.zero;
		Vector3 forward = snakeHead.transform.forward * forwardValue;
		Vector3 needPos = snakeHead.transform.position - forward + (Vector3.up *upMultiplier);
		transform.position = Vector3.SmoothDamp(transform.position, needPos,
		                                        ref velocity,dampStrength);
		transform.LookAt (snakeHead.transform);
		transform.rotation = snakeHead.transform.rotation;
	}
}
