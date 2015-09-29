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
		case "BeanSprouts(Clone)":
		case "BitterMelon(Clone)":
		case "Carrot(Clone)":
		case "Cereal(Clone)":
		case "Chickpea(Clone)":
		case "Fish(Clone)":
		case "Greenbean(Clone)":
		case "GreenVeggie(Clone)":
		case "Jalepeno(Clone)":
		case "Lettuce(Clone)":
		case "Mushroom(Clone)":
		case "Pea(Clone)":
		case "Pumpkin(Clone)":
		case "Raddish(Clone)":
		case "Shrimp(Clone)":
			SpawnDestroy.FinalScore += 10;
//			Debug.Log("score" + finalScore.ToString());
//			GameScore.text = finalScore.ToString();
//			SpawnDestroy.finalScore += 10;
//			Debug.Log ("aft" + SpawnDestroy.FinalScore);

			break;


		case "Rice(Clone)":
		case "ChickenLeg(Clone)":
			SpawnDestroy.FinalScore += 9;
			break;
		case "Bagel(Clone)":
			SpawnDestroy.FinalScore += 8;
			break;
		case "LambChop(Clone)":
		case "Bread(Clone)":
		case "LoafBread(Clone)":
			SpawnDestroy.FinalScore += 7;
			break;
		case "Cheese(Clone)":
			SpawnDestroy.FinalScore += 5;
			break;
		case "Sausage(Clone)":
			SpawnDestroy.FinalScore += 4;
			break;
		case "Burger(Clone)":
		case "Candy(Clone)":
		case "Jello(Clone)":
		case "Pancake(Clone)":
		case "Sushi(Clone)":
			SpawnDestroy.FinalScore += -5;
			break;
		case "Coke(Clone)":
		case "Doughnut(Clone)":
		case "FriedChicken(Clone)":
		case "Fries(Clone)":
		case "Hotdog(Clone)":
		case "IceTea(Clone)":
		case "InstantNoodle(Clone)":
			SpawnDestroy.FinalScore += -10;
			break;
//		case "Ball(Clone)":

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
		RightSound.Play();
		objectPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 1);
		StartCoroutine(RespawnObject());
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
