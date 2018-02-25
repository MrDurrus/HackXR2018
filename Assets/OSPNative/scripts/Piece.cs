using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// floating pieces 
public class Piece : MonoBehaviour {

	GameObject marker;
	Vector3 markerPos;
	List<Vector3> platformPts, cubePts;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		// disintegrates block five seconds after it's attached
		timer += Time.deltaTime;
		if (timer > waitTime) {
			this.transform.parent = null;
			Destroy (this);
		}
	}
	
	// move floating piece using controller
	void move(GameObject controller, GameObject platform) {
		// distance between controller and the floating cube
		Vector3 distance = controller.transform.position - this.transform.position;
		this.transform.position = 2 * ((distance).normalized) + this.transform.position;
	}	

	// locks cube to platform
	void lockCube(GameObject platform) {
		// list of platform vertices 
		Mesh platformMesh = platform.GetComponent<MeshFilter>().mesh;
		Vector3[] platformPts = platformMesh.vertices;
		// list of cube vertices
		Mesh cubeMesh = this.GetComponent<MeshFilter> ().mesh;
		Vector3[] cubePts = cubeMesh.vertices;

		// iterate through vertices to find nearest side to connect
		for (int i = 0; i < platformPts.Length; i++) {
			for (int j = 0; j < cubePts.Length; j++) {
				// distance between platform and cube
				float distance = Vector3.Distance (platformPts [i], cubePts [j]);
				// shows marker
				if (distance < 10.0) {
					GameObject marker = GameObject.CreatePrimitive (PrimitiveType.Cube);
				}
				// locks cube
				if (distance < 2.0) {
					this.transform.parent = platform.transform;
					marker.transform.localPosition = Vector3.zero;
				}
			}
		}
	}
}

