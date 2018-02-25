using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject platform;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}

	// save reference for the platform
	void onCollisionEnter(Collision col) {
		// connect cube with player
		if (col.gameObject.GetComponent<Piece>() != null) {
			col.transform.parent = this.transform;
			platform = col.gameObject;
		}
	}

	void onCollisionExit(Collision col) {
		// unlink cube and player
		if (col.gameObject.GetComponent<Piece> () != null) {
			col.transform.parent = null;
		}
	}
}
