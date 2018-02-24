using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// player's position
		Vector3 playerPos = this.transform.position;
	}

	// link platform with player once they come into contact
	void onTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Cube") {
			col.transform.parent = this.transform.parent;
		}
	}

	void onTriggerExit(Collider col) {
		
			
}
