using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PercentScript : MonoBehaviour {

	public Text text;
	private float cubesTotal = 20f*20f*20f;
	public int cubesEaten = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		text.text = (cubesEaten/cubesTotal) * 100 + "% eaten";
	}
}
