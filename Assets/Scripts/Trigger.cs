﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRigger");
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Strya");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Coll");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("TRiggeExitr");
    }

    void OnCollisionStay(Collision other)
    {
        Debug.Log("ColiStrya");
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("CollExit");
    }
}
