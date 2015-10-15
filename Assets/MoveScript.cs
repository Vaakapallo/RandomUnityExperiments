using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	public float speed = 10f;
	public float angle = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Rotate(Vector3.left,angle);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Rotate(Vector3.right, angle);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate(Vector3.up, angle);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate(Vector3.down, angle);
		}
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
	}
}
