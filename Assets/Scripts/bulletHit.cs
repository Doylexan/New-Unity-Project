﻿using UnityEngine;
using System.Collections;

public class bulletHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){

		if (col.gameObject.tag == "bird") {
			Destroy (col.gameObject);
		}

	}

}
