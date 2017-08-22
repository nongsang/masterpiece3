using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour {

	GameObject FirstAid1, FirstAid2, hp;
	public static bool SaveFirstAid1, SaveFirstAid2;
	public static float Savehp;

	private void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start()
	{
		FirstAid1 = GameObject.Find("FirstAid1");
		FirstAid1 = GameObject.Find("FirstAid2");
		hp = GameObject.Find("HPImage");
	}

	private void Update()
	{
		if (FirstAid1 == true)
			FirstAid1.GetComponent<SpriteRenderer>().enabled = true;
		if(FirstAid2 == true)
			FirstAid2.GetComponent<SpriteRenderer>().enabled = true;
	}
}
