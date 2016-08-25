using UnityEngine;
using System.Collections;

public class FPSScript : MonoBehaviour {
	public int zandan = 7; 

	public bool reload = false;
	public float reloadstart = 0;
	public int reloadend = 1;

	// Use this for initialization
	void Start () {
	}

	RaycastHit hit;
	// Update is called once per frame
	void Update () {

		//attack
		if(Input.GetMouseButtonDown(0) && zandan >= 1 && reload == false){
			zandan--;
		}
		//reload
		if(Input.GetMouseButtonDown(1)){
			zandan = 7;
			reload = true;
		}
		if(reload == true){
			reloadstart += Time.deltaTime;
		}
		if(reloadstart >= reloadend){
			reload = false;
		}

	

	}
}
