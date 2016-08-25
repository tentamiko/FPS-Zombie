using UnityEngine;
using System.Collections;

public class EventManagerScript : MonoBehaviour {

	public int eventnumber = 0;
	public GameObject Player;

	public Transform target1;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (eventnumber == 0) {
			PlayerNavScript.target = target1;
			Player.SendMessage ("Advance");
		}
	}
}
