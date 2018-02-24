using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour {

	// semi-transparent marker
	GameObject marker;
	Vector3 markerPos;

	// Use this for initialization
	void Start () {
		// create marker with box collider
		marker = GameObject.CreatePrimitive(PrimitiveType.Cube);
		marker.AddComponent (BoxCollider);
	}
	
	// Update is called once per frame
	void Update () {}

	void attachMarker(GameObject player, GameObject platform) {
		// Disable collisions with the cube
		if(platform.collider2D) {
			Object1.collider2D.enabled = false;
		}
		// Don't allow physics to affect the object
		if(platform.rigidbody2D){
			Object1.rigidbody2D.isKinematic = true;
		}
		// Attach marker to cube
		marker.transform.parent = platform.transform;
		// Center with no offset
		marker.transform.localPosition = Vector3.zero;
		Debug.Log (marker.transform.localPosition);
	}

	void lockCube(GameObject platform) {
		// find position of grabbedCube
		Vector3 cubePos = this.transform.position;

		if (cubePos - markerPos < 10) {
			// attach grabbed cube to existing platform
			this.transform.parent = platform.transform;
			marker.transform.localPosition = Vector3.zero;
			// remove marker after pieces are attached
			if (marker != null) {
				Destroy (marker);
			}
		}
	}
		
}
