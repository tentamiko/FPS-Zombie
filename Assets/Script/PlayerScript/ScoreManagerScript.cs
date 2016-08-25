using UnityEngine;
using System.Collections;

public class ScoreManagerScript : MonoBehaviour {

	public int score = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddScore(){
		score += 100;
	}

	public void LoseScore(){
		if (score >= 300) {
			score -= 300;
		} else {
			score = 0;
		}
	}

}
