using UnityEngine;
using System.Collections;

public class PlayerNavScript : MonoBehaviour {

	public Transform target;
	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination (target.position);
	}
		
	public void Advance(){
		agent.SetDestination (target.position);
	}

}
