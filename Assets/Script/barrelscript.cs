using UnityEngine;
using System.Collections;

public class barrelscript : MonoBehaviour {

	public GameObject barrel;
	public GameObject bomb;
	public GameObject bombeffect;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter (Collider collision){
		if (collision.gameObject.tag == "tama" || collision.gameObject.tag == "bomb") {
				Instantiate(bomb,new Vector3 (barrel.transform.position.x,barrel.transform.position.y,barrel.transform.position.z),
					Quaternion.Euler(0,0,0));
				Instantiate(bombeffect,new Vector3 (barrel.transform.position.x,barrel.transform.position.y,barrel.transform.position.z),
					Quaternion.Euler(0,0,0));
			Destroy (barrel);
		}
	}

}
