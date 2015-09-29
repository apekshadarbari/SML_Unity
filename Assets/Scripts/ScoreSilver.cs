using UnityEngine;
using System.Collections;

public class ScoreSilver : MonoBehaviour {
	public GameObject prefabs;
	
	
	// Use this for initialization
	void Start () {
		if (SpawnDestroy.FinalScore > 200) {
			StartCoroutine(starGenerator());
		}
		
		
	}

	IEnumerator starGenerator (){
		Vector3 starPosition = new Vector3(4.88f, 0.73f, 0);
		yield return new WaitForSeconds (0.6f);
		Instantiate(prefabs, starPosition, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

