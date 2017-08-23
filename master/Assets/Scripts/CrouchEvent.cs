using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchEvent : MonoBehaviour {

	//Transform Player;

	bool enable = false;

	private void Awake()
	{
		System.GC.Collect();
	}

	// Use this for initialization
	//void Start()
	//{
	//	Player = GameObject.Find("FPSController").transform;
	//}

	//Update is called once per frame
	//void Update()
	//{

	//}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player" && enable == true)
			other.transform.localScale = new Vector3(1, 0.8f, 1);
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			other.transform.localScale = new Vector3(1, 1.6f, 1);
		}
		else if (other.tag == "OBJECT")
		{
			Enable();
			Invoke("Disable", 20);
		}
	}

	private void Enable()
	{
		enable = true;
	}

	void Disable()
	{
		enable = false;
	}
}
