﻿using UnityEngine;
using System.Collections;

public class Flipperspin : MonoBehaviour {

    public float flipperstrength;
    public float pushforce;
    private HingeJoint hinge;


	void Start () {
        hinge = GetComponent<HingeJoint>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKeyDown("m"))
        {
            Vector3 f = transform.up * flipperstrength;
            Vector3 p = (transform.right) + transform.position * pushforce;
            GetComponent<Rigidbody>().AddForceAtPosition(f, p);
        }
	
	}
}