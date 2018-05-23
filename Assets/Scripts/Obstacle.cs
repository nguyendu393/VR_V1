using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : SomeThing {

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("nhsnsvsh");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Trung cmnr");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("nununu");
        if (other.tag == "Player")
        {
            Debug.Log("Trung cmnr");
        }
    }
    // Update is called once per frame
    new void Destroy()
    {
        if (transform.parent.position.z < -2f)
        {
           Destroy(this.gameObject);
        }

    } 
    void Update () {
        //Debug.Log(transform.parent.position.z);
        Destroy();
    }
}
