﻿using UnityEngine;
using System.Collections;

public class sparks : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, 3);
	}
}
