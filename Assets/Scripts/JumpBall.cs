using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBall : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		if (Input.GetMouseButtonDown (0)) 
		{

			rb.AddRelativeForce (Vector3.up *1000f);

		}
		
	}
}
