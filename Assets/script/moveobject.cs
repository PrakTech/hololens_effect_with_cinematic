using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveobject : MonoBehaviour {

    public Vector3 teleportpoint;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.MovePosition(transform.position + transform.forward * Time.deltaTime);

	}
}
