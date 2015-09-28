using UnityEngine;
using System.Collections;

public class TestMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver(){
		Debug.Log ("over");
	}

	void OnMouseDown(){
		Debug.Log ("Down");
	}

	void OnMouseExit(){
		Debug.Log ("exit");
	}
}

