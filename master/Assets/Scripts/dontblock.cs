using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontblock : MonoBehaviour {

	SphereCollider sc;

	// Use this for initialization
	void Start () {
		sc = GetComponent<SphereCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		//sc.enabled = false;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.name == "FPSController")
			sc.enabled = false;
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision.collider.name == "FPSController")
			sc.enabled = true;
	}
}
