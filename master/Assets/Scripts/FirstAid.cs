using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAid : MonoBehaviour
{

	bool enable = false;
	bool take = false;

	SpriteRenderer FirstAid1, FirstAid2;

	// Use this for initialization
	void Start()
	{
		FirstAid1 = GameObject.Find("FirstAid1").GetComponent<SpriteRenderer>();
		FirstAid2 = GameObject.Find("FirstAid2").GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update()
	{
		if (enable == true && take == true)
		{
			//if (FirstAid1.enabled == true)
			//	FirstAid2.enabled = true;
			//else if (FirstAid2.enabled == true)
			FirstAid1.enabled = true;
			Destroy(gameObject);
		}
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
