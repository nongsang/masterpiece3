using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAid2 : MonoBehaviour {

	bool take = false;

	public GameObject Save;

	private void Awake()
	{
		System.GC.Collect();
	}

	// Use this for initialization
	void Start () {
		Save = GameObject.Find("Save");
	}
	
	// Update is called once per frame
	void Update () {
		if (take == true)
			Destroy(gameObject);
	}

	private void OnDestroy()
	{
		Save.GetComponent<Save>().SaveFirstAid2 = true;
	}

	private void Take()
	{
		take = true;
	}
}
