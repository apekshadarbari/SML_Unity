using UnityEngine;
using System.Collections;

public class ScoreBronze : MonoBehaviour {
	public GameObject prefabs;
	public AudioSource TadaSound;

	// Use this for initialization
	void Start () {

		TadaSound = GameObject.Find ("TadaSound").GetComponent<AudioSource>() as AudioSource;

		Vector3 starPosition = new Vector3(-4.88f, 0.73f, 0);
		Instantiate(prefabs, starPosition, Quaternion.identity);
		TadaSound.Play();


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
