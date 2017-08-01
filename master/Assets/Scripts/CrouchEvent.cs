﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchEvent : MonoBehaviour {

	Transform Player;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find("FPSController").transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
			Player.localScale = new Vector3(1, 0.8f, 1);
	}

	private void OnTriggerExit(Collider other)
	{
		if(other.tag == "Player")
		{
			Player.localScale = new Vector3(1, 1.6f, 1);
		}
	}
}
