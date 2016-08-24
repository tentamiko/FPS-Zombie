using UnityEngine;
using System.Collections;

public class bombscript : MonoBehaviour {

	public GameObject bomb;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (bomb, 0.5f);
	}
}
