using UnityEngine;
using System.Collections;

public class MoveEverySecond : MonoBehaviour {

	private bool up = true;
	private bool left = true;
	private bool back = true;
	private float speed = 0.5f;

	// Use this for initialization
	void Start () {

		InvokeRepeating("MoveUp", 0, 1);
		InvokeRepeating("MoveLeft", 0, 1.5f);
		InvokeRepeating("MoveBack", 0, 1.5f);
		InvokeRepeating("ChangeSpeed", 0, 2f);

	}
	
	// Update is called once per frame
	void Update () {
		//transform.position += (Vector3.up);
		//print (speed);
		Vector3 velocity;
		if (up) {
			velocity = Vector3.up * speed;
		} else {
			velocity = Vector3.down * speed;
		}
		if (left) {
			velocity = Vector3.left * speed + velocity;
		} else {
			velocity = Vector3.right * speed + velocity;
		}
		if (back) {
			velocity = Vector3.back * speed + velocity;
		} else {
			velocity = Vector3.forward * speed + velocity;
		}
		transform.position += velocity * Time.deltaTime;
	}

	void MoveUp(){
		up = !up;
	}

	void MoveLeft(){
		left = !left;
	}

	void MoveBack(){
		back = !back;
	}

	void ChangeSpeed(){
		speed = Random.Range (2.0f, 10f);
	}
}
