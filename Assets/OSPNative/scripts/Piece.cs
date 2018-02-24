using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// floating pieces 
public class Piece : MonoBehaviour {

	GameObject marker;
	Vector3 markerPos;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {}

	// move floating piece using controller
	void move(GameObject controller, GameObject platform) {
		// distance between controller and the floating cube
		Vector3 distance = controller.transform.position - this.transform.position;
		this.transform.position = 2 * ((distance).normalized) + this.transform.position;
	}
		
}

