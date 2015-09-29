using UnityEngine;
using System.Collections;

public class ScoreGold : MonoBehaviour {
	public GameObject prefabs;
	

	// Use this for initialization
	void Start () {
		if (SpawnDestroy.FinalScore > 400 ) {
			StartCoroutine(starGenerator());
		}
		
		
	}

	IEnumerator starGenerator (){
		Vector3 starPosition = new Vector3(0f, 2.23f, 0);
		yield return new WaitForSeconds (1.2f);
		Instantiate(prefabs, starPosition, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
