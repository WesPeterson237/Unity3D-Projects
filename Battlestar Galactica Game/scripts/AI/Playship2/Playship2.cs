﻿using UnityEngine;
using System.Collections;

public class Playship2 : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate (0, -speed, 0);

	}
}
