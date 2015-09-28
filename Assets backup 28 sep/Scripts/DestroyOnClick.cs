using UnityEngine;
using System.Collections;

public class DestroyOnClick : MonoBehaviour {





	// Use this for initialization
	void Start () 
	{
		
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
			Debug.Log ("berf" + SpawnDestroy.FinalScore);
			SpawnDestroy.FinalScore += 10;
//			SpawnDestroy.finalScore += 10;
			Debug.Log ("aft" + SpawnDestroy.FinalScore);
			Destroy (gameObject);
			break;
		case "Ball(Clone)":
		case "Balloon(Clone)":
		case "Baseball(Clone)":
		case "Basketball(Clone)":
		case "Bomb(Clone)":
		case "Box(Clone)":
		case "Clock(Clone)":
		case "Cloud(Clone)":
		case "Flower(Clone)":
		case "Glasses(Clone)":
		case "Hats(Clone)":
		case "Key(Clone)":
		case "Magnifier(Clone)":
		case "MusicNotes(Clone)":
		case "Notebook(Clone)":
		case "Pencil(Clone)":
		case "PriceTag(Clone)":
		case "RubicsCube(Clone)":
		case "ShippingBag(Clone)":
		case "Socks(Clone)":
		case "Sun(Clone)":
		case "Tree(Clone)":
			Debug.Log ("berf" + SpawnDestroy.FinalScore);
			SpawnDestroy.FinalScore -= 6;
			//			SpawnDestroy.finalScore += 10;
			Debug.Log ("aft" + SpawnDestroy.FinalScore);
			break;
		default:
			break;
		
		}

		Debug.Log ("fin" + SpawnDestroy.FinalScore);
//		SpawnDestroy.newGenerator ();
	}   
}
