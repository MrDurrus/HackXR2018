<<<<<<< HEAD
﻿using System.Collections; using System.Collections.Generic; using UnityEngine;  public class World : MonoBehaviour {  	// number of floating cubes 	public int count;  	// Use this for initialization 	void Start () { 		// generates cubes 		for (; count < 5; count++) { 			new Piece (); 		} 	}  	// Update is called once per frame 	void Update () { 		// make sure there's always five cubes 		if (count < 5) { 			new Piece (); 			count++; 		} 	} }
=======
﻿public class World : MonoBehaviour {  	// number of floating cubes 	int count;  	// Use this for initialization 	void Start () { 		// generates cubes 		for (; count < 5; count++) { 			new Piece (); 		} 	}  	// Update is called once per frame 	void Update () { 		// make sure there're always five cubes 		if (count < 5) { 			new Piece (); 			count++; 		} 	} }
>>>>>>> Bonnie
