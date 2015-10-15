using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {

	public float xRotation;
	public float yRotation;
	public float zRotation;
	private bool change = false;
	private int changeCounter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.rotation.x < 0 && xRotation < 0 && !change) {
			xRotation *= -1;
			change = true;
		}
		if (gameObject.transform.rotation.x > 0 && xRotation > 0 && !change) {
			xRotation *= -1;
			change = true;
		}
		if (change) {
			changeCounter++;
			//print (changeCounter);
		}

		if (changeCounter > 50) {
			change = false;
			changeCounter = 0;
		}

		gameObject.transform.Rotate (new Vector3(xRotation,yRotation,zRotation));
		//gameObject.transform.Translate (new Vector3(Mathf.Sin (gameObject.transform.localPosition.x), Mathf.Sin (gameObject.transform.localPosition.y), Mathf.Sin (gameObject.transform.localPosition.z)));
		//gameObject.transform.position.Set (Mathf.Sin (gameObject.transform.localPosition.x), Mathf.Sin (gameObject.transform.localPosition.y), Mathf.Sin (gameObject.transform.localPosition.z));

	}
}
