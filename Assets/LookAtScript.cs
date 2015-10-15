using UnityEngine;
using System.Collections;

public class LookAtScript : MonoBehaviour {

	private GameObject target;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Follow");
	}
	
	// Update is called once per frame
	void Update () {
		Transform[] childrenTransforms = gameObject.GetComponentsInChildren<Transform>();
		foreach (Transform t in childrenTransforms) {
			if(!t.Equals(transform)){
				t.LookAt (target.transform);
			}
		}
	}
}
