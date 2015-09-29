using UnityEngine;
using System.Collections;

public class Ending : MonoBehaviour {
	private GameObject endBtn;

	private GameObject endImg;
	
	
	
	
	void Start () {
		endBtn = GameObject.Find("EndButton");
	
		
		endBtn.GetComponent<UITexture> ().enabled = true;
		
	}
	
	void OnMouseDown(){
		Application.LoadLevel("Game");
	}

	// Update is called once per frame
	void Update () {
	
	}
}
