﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazelook : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(Camera.main.transform.position, Vector3.up);
        transform.Rotate(90, 0, 0);
    }
}
