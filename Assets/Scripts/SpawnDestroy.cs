using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpawnDestroy : MonoBehaviour {

	public static SpawnDestroy Instance;


	public GameObject[] prefabs;
	public float delay = 2.0f;
	public bool active = true;
	public Vector2 delayRange = new Vector2(1,2);
	static int _finalScore = 0;

	public Text ScoreText;
	
	// Use this for initialization
	void Start () {
//		ResetDelay ();
//		StartCoroutine (EnemyGenerator ());
		EnemyGenerator ();
		ScoreText = GameObject.Find ("ScoreDisplay").GetComponent<Text> ();
		ScoreText.text = "Test";
	}

	void Awake(){
		Instance = this;
	}

	void Update(){
		ScoreText.text = FinalScore.ToString();
	}
	
//	 IEnumerator EnemyGenerator(){
	void EnemyGenerator(){
//		yield return new WaitForSeconds(delay);

		for (int i = 0; i<8; i++) {
			for (int j = 0; j< 8; j++){
				if (active) {
//					var newTransform = transform; newTransform.position

//					Vector3 newTransform = new Vector3(-9f + (i*1.75f), -6.25f+(j*1.75f),0);

					float randomPlacement1 = Random.Range(0, 1f) - Random.Range(0, 1f);
					float randomPlacement2 = Random.Range(0, 1f) - Random.Range(0, 1f);

					Vector3 newTransform = new Vector3(-8.5f + (i*1.70f) + randomPlacement1, -6.25f+(j*1.75f) + randomPlacement2,0);


					Instantiate(prefabs[Random.Range(0, prefabs.Length)], newTransform, Quaternion.identity);
//					ResetDelay();


				}
			}

			Debug.Log ("done generator");
		}



	}

//	public int FinalScore
//	{
//		get
//		{
//			return finalScore;
//		}
//		set
//		{
//			finalScore = value;
//			
//		}
//	}
//
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

//	ScoreText.text = ""+value;

//	public void newGenerator(){
//		StartCoroutine(EnemyGenerator());
//	}


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
