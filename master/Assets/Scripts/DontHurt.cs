using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontHurt : MonoBehaviour {

	public GameObject damage;

	private void Awake()
	{
		System.GC.Collect();
	}

	//// Use this for initialization
	//void Start () {

	//}

	//// Update is called once per frame
	//void Update () {

	//}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
			damage.SendMessage("DamagedFalse", SendMessageOptions.DontRequireReceiver);
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
			damage.SendMessage("DamagedTrue", SendMessageOptions.DontRequireReceiver);
	}
}
