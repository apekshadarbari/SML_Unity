using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DestroyOnClick : MonoBehaviour {

	public AudioSource RightSound;
	public GameObject WrongAnswer;
	private Vector3 objectPosition;
	private GameObject[] prefabs;
//	private Text GameScore;
//	private int finalScore;

	// Use this for initialization
	void Awake () 
	{
		RightSound = GameObject.Find ("RightSound").GetComponent<AudioSource>() as AudioSource;
		prefabs = SpawnDestroy.Instance.prefabs;
//		GameScore = SpawnDestroy.Instance.ScoreText;
//		finalScore = SpawnDestroy.Instance.finalScore;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
//	void OnMouseOver(){
//		Debug.Log ("??");
//	}
//
//	void OnMouseExit(){
//		Debug.Log ("exit");
//	}

	void OnMouseDown(){
		// this object was clicked - do something
		Debug.Log ("gameobject name:" + gameObject.name);

		switch (gameObject.name) {
		case "Apple(Clone)":
		case "bigpurplegrapes(Clone)":
		case "Cherry(Clone)":
		case "Grape(Clone)":
		case "Kiwi(Clone)":
		case "Lemon(Clone)":
		case "Mango(Clone)":
		case "Orange(Clone)":
		case "Pears(Clone)":
		case "PurpleGrape(Clone)":
		case "RedGrape(Clone)":
		case "Strawberry(Clone)":
		case "Watermelon(Clone)":
			SpawnDestroy.FinalScore += 10;
//			Debug.Log("score" + finalScore.ToString());
//			GameScore.text = finalScore.ToString();
//			SpawnDestroy.finalScore += 10;
//			Debug.Log ("aft" + SpawnDestroy.FinalScore);
			RightSound.Play();
			objectPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 1);
			StartCoroutine(RespawnObject());

//			Debug.Log ("respawn");


			break;
//		case "Ball(Clone)":
//		case "Balloon(Clone)":
//		case "Baseball(Clone)":
//		case "Basketball(Clone)":
//		case "Bomb(Clone)":
//		case "Box(Clone)":
//		case "Clock(Clone)":
//		case "Cloud(Clone)":
//		case "Flower(Clone)":
//		case "Glasses(Clone)":
//		case "Hats(Clone)":
//		case "Key(Clone)":
//		case "Magnifier(Clone)":
//		case "MusicNotes(Clone)":
//		case "Notebook(Clone)":
//		case "Pencil(Clone)":
//		case "PriceTag(Clone)":
//		case "RubicsCube(Clone)":
//		case "ShippingBag(Clone)":
//		case "Socks(Clone)":
//		case "Sun(Clone)":
//		case "Tree(Clone)":
//			Debug.Log ("berf" + SpawnDestroy.FinalScore);
//			SpawnDestroy.FinalScore -= 6;
//			//			SpawnDestroy.finalScore += 10;
//			Debug.Log ("aft" + SpawnDestroy.FinalScore);
//			Vector3 WrongAnswerPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -2);
//			WrongAnswer = GameObject.Instantiate(GameObject.Find("Wrong"), WrongAnswerPos, Quaternion.identity) as GameObject;
//			StartCoroutine(DestroyWrong());
//			break;
		default:
			break;
		
		}

	}   

	IEnumerator RespawnObject(){
		gameObject.GetComponent<Renderer> ().enabled = false;
		yield return new WaitForSeconds(3);
		Instantiate(prefabs[Random.Range(0, prefabs.Length)], objectPosition, Quaternion.identity);
		Destroy (gameObject);

	}

	IEnumerator DestroyWrong(){
		yield return new WaitForSeconds(1);
		Destroy (WrongAnswer);
	}
}
