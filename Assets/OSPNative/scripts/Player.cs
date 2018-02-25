using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	GameObject platform;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}

	// save reference for the platform
	void onCollisionEnter(Collision col) {
		if (col.gameObject.name == "Cube") {
			platform = col.gameObject;
		}
	}
}
