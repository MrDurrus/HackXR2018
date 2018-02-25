using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// floating pieces 
public class Piece : MonoBehaviour {

	boolean attached = true;
	GameObject marker;
	Vector3 markerPos;
	List<Vector3> platformPts, cubePts;

	// Use this for initialization
	void Start() {}

	// Update is called once per frame
	void Update() {}

	public void pullPiece(GameObject controller, GameObject platform) {
		if (!attached) {
			move (controller);
			lockCube (platform);
		}
	}

	// move floating piece using controller
	public void move(GameObject controller) {
		// distance between controller and the floating cube
		Vector3 distance = controller.transform.position  + 5*controller.transform.forward.normalized - this.transform.position;
		if (distance.magnitude < 2) {
			this.transform.position = controller.transform.position + 5 * controller.transform.forward.normalized;
		} else {
			this.transform.position = 0.7f * ((distance).normalized) + this.transform.position;
		}
	}

	// locks cube to platform
	void lockCube(GameObject platform) {
		// list of platform vertices 
		Mesh platformMesh = platform.GetComponent<MeshFilter>().mesh;
		Vector3[] platformPts = platformMesh.vertices;
		// list of cube vertices
		Mesh cubeMesh = this.GetComponent<MeshFilter>().mesh;
		Vector3[] cubePts = cubeMesh.vertices;

		// iterate through vertices to find nearest side to connect
		for (int i = 0; i < platformPts.Length; i++) {
			for (int j = 0; j < cubePts.Length; j++) {
				// distance between platform and cube
				float distance = Vector3.Distance(platformPts[i], cubePts[j]);
				// shows marker
				if (distance < 20.0) {
					GameObject marker = GameObject.CreatePrimitive(PrimitiveType.Cube);
				}
				// locks cube
				if (distance == 5.0 && !OVRInput.Get(OVRInput.RawButton.RIndexTrigger &&)) {
					this.transform.parent = platform.transform;
					marker.transform.localPosition = Vector3.zero;
				}
			}
		}
		attached = true;
	}
}
