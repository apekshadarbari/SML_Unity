using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreHandler : MonoBehaviour {

	public int highScore = 0;
	public Text Score;
	public Text Encouragement;

	private float tempScore = 0.0f;

	string highScoreKey = "HighScore";

	// Use this for initialization
	void Start () {
		highScore = PlayerPrefs.GetInt(highScoreKey,0);    
		Score = GameObject.Find ("Score").GetComponent<Text> ();
		Encouragement = GameObject.Find ("Encouragement").GetComponent<Text> ();
		Debug.Log ("score:" + SpawnDestroy.FinalScore);
//		Score.text = "Score:" + SpawnDestroy.FinalScore;
		StartCoroutine(AnimateFinalScore (SpawnDestroy.FinalScore, 5.0f));

		if (highScore > SpawnDestroy.FinalScore) {
			Encouragement.text = "Try Again?";
		} else if (highScore == SpawnDestroy.FinalScore) {
			Encouragement.text = "So Close!";
		} else {
			Encouragement.text = "Good Job!";
		}

//		if (SpawnDestroy.FinalScore > 0 * * SpawnDestroy.FinalScore < 50) {
//
//		}

//		Score.text = "Score:" + score.ToString();
	}

	IEnumerator AnimateFinalScore(float endValue, float duration)
	{
		float lerpTime = 0f;
		
		while (lerpTime < duration)
		{
			lerpTime += Time.deltaTime;
			tempScore = Mathf.Lerp (tempScore, endValue, lerpTime / duration); // Replace scoreToDisplay with the score you are displaying
			Debug.Log(tempScore);
			Score.text = ((int)tempScore).ToString();
			yield return null;

		}
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
