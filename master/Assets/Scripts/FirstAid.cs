using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAid : MonoBehaviour
{

	public bool enable = false;
	public bool take = false;

	public GameObject Save;

	private void Awake()
	{
		System.GC.Collect();
	}

	// Use this for initialization
	void Start()
	{
		//FirstAid1 = GameObject.Find("FirstAid1").GetComponent<SpriteRenderer>();
		//FirstAid1.GetComponent<SpriteRenderer>().enabled = true;
		//FirstAid2 = GameObject.Find("FirstAid2").GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update()
	{
		if (enable == true && take == true)
			//FirstAid1.GetComponent<SpriteRenderer>().enabled = true;
			//if (FirstAid1.enabled == true)
			//	FirstAid2.enabled = true;
			//else if (FirstAid2.enabled == true)
			//FirstAid1.enabled = true;
			Destroy(gameObject);
	}

	private void OnDestroy()
	{
		//Destroy(gameObject);
		//FirstAid1.GetComponent<SpriteRenderer>().enabled = true;
		Save.GetComponent<Save>().SaveFirstAid1 = true;
	}

	private void Switch()
	{
		enable = true;
	}

	private void Take()
	{
		take = true;
	}
}
