using UnityEngine;
using UnityEditor;
using System.Collections;

public class MenuScript : MonoBehaviour
{

	[MenuItem ("Craziness/Create a Grid")]
	static void DoSomething () {
		for (float i = 0f; i < 21; i++) {
			for (float j = 0f; j < 2; j++) {
				GameObject parent = GameObject.FindGameObjectWithTag ("Wall");

				GameObject newTile = (GameObject)PrefabUtility.InstantiatePrefab (Resources.Load ("WallPieceStatic"));
				newTile.transform.position = parent.transform.position + new Vector3 (i * 2f, j * 11.5f, 0);
				newTile.transform.parent = parent.transform;
			}
		}
	}

	[MenuItem ("Craziness/Create a cube From Selection")]
	static void CreateACube () {
		GameObject holder = new GameObject ();
		GameObject parent = Selection.activeGameObject;
		holder.transform.position = parent.transform.position;

		for (float i = 0f; i < 20; i++) {
			for (float j = 0f; j < 20; j++) {
				for (float k = 0f; k < 20; k++) {
					GameObject newTile = (GameObject)Instantiate (parent);
					newTile.transform.position = parent.transform.position + new Vector3 (i * 1f, j * 1f, k * 1f);
					newTile.transform.parent = holder.transform;
				}
			}
		}
	}

	[MenuItem ("Craziness/Add Child Cubes/1")]
	static void MakeAChild1 (){
		addChildCubes (1);
	}

	[MenuItem ("Craziness/Add Child Cubes/5")]
	static void MakeAChild5 (){
		addChildCubes (5);
	}

	[MenuItem ("Craziness/Add Child Cubes/10")]
	static void MakeAChild10 (){
		addChildCubes (10);
	}

	[MenuItem ("Craziness/Add Child Cubes/20")]
	static void MakeAChild20 (){
		addChildCubes (20);
	}

	[MenuItem ("Craziness/Add Child Cubes/100")]
	static void MakeAChild100 (){
		addChildCubes (100);
	}

	[MenuItem ("Craziness/Add Child Cubes/1000")]
	static void MakeAChild1000 (){
		addChildCubes (1000);
	}

	static void addChildCubes(int value){
		GameObject parent = Selection.activeGameObject;
		
		for(int i = 0; i < value; i++){
			GameObject newTile = (GameObject)PrefabUtility.InstantiatePrefab (Resources.Load ("HingedSnakePart"));
			newTile.transform.position = parent.transform.position + Vector3.back * 0.9f;
			newTile.GetComponent<FollowScript>().toFollow = parent.transform;
			parent = newTile;
		}
	}
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
