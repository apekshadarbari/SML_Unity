using UnityEngine;
using System.Collections;

public class SpawnDestroy : MonoBehaviour {

	public GameObject[] prefabs;
	public float delay = 2.0f;
	public bool active = true;
	public Vector2 delayRange = new Vector2(1,2);
	static int _finalScore = 0;
	
	// Use this for initialization
	void Start () {
//		ResetDelay ();
		StartCoroutine (EnemyGenerator ());
//		EnemyGenerator ();
	}
	
	 IEnumerator EnemyGenerator(){
		yield return new WaitForSeconds(delay);

		for (int i = 0; i<8; i++) {
			for (int j = 0; j< 8; j++){
				if (active) {
//					var newTransform = transform; newTransform.position

					Vector3 newTransform = new Vector3(-52.5f+ (i*15), -45+(j*15),0);

					Instantiate(prefabs[Random.Range(0, prefabs.Length)], newTransform, Quaternion.identity);
					ResetDelay();
				}
			}

			Debug.Log ("done generator");
		}


//		var newTransform = transform;
//		Instantiate(prefabs[Random.Range(0, prefabs.Length)], newTransform.position, Quaternion.identity);

	}

	public static int FinalScore
	{
		get
		{
			return _finalScore;
		}
		set
		{
			_finalScore = value;
		}
	}



	public void newGenerator(){
		StartCoroutine(EnemyGenerator());
	}


//	void OnMouseDown(){
//		// this object was clicked - do something
//		Debug.Log ("mouse down");
//		Destroy (gameObject);
//		StartCoroutine(EnemyGenerator());
//	}   

	void ResetDelay(){
		Debug.Log ("reset delay");
		delay = Random.Range (delayRange.x, delayRange.y);
	}
}
