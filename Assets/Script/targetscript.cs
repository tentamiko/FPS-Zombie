using UnityEngine;
using System.Collections;

public class targetscript : MonoBehaviour {
	private Vector3 position;
	private Vector3 screenToWorldPointPosition;
	public GameObject dangan;
	public GameObject gun;
	private int zandan = 5;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//attack
		if(Input.GetMouseButtonDown(0)){
			if(zandan>0){
				Instantiate(dangan,new Vector3 (gun.transform.position.x,gun.transform.position.y + 0.2f,gun.transform.position.z + 0.4f),
				            Quaternion.Euler(0,0,0));
			zandan--;
			}
		}
		 
		if (Input.GetMouseButtonDown (1)) {
			zandan = 5;
		}

	}
}
