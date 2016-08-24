using UnityEngine;
using System.Collections;

public class danganscript : MonoBehaviour {

	GameObject pis;
	public GameObject dangan;
	// Use this for initialization
	void Start () {
		pis = GameObject.Find("Player/Main Camera/Макаров (Prefab)");
		GetComponent<Rigidbody> ().velocity = pis.transform.forward * -1 * 10;
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (dangan, 1);
	}
}
