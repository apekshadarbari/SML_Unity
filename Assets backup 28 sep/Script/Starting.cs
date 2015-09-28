using UnityEngine;
using System.Collections;

public class Starting : MonoBehaviour {

	private GameObject infoBtn;
	private GameObject startBtn;

	private GameObject startImg;
	private GameObject infoImg;




	void Start () {
		infoBtn = GameObject.Find("InfoBtn");
		startBtn = GameObject.Find("StartBtn");

		startImg =GameObject.Find("StartImage");
		infoImg = GameObject.Find("InfoImage");

		startImg.GetComponent<UITexture> ().enabled = true;
		infoImg.GetComponent<UITexture> ().enabled = true;

	}
	
	public void clickInfoBtn(){
		Application.LoadLevel("Scene2");
	//	startImg.GetComponent<UITexture> ().enabled = false;
	//	infoImg.GetComponent<UITexture> ().enabled = true;
	//	infoBtn.SetActive (false);
	}



	public void clickStartBtn(){
		Application.LoadLevel("Game");

	}


}
