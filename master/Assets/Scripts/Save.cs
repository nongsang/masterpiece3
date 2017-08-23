using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour {

	public GameObject FirstAid1, FirstAid2, hp;
	public bool SaveFirstAid1, SaveFirstAid2;
	public float Savehp = 3.0f;
	public bool SaveNPC1, SaveNPC2;

	public static Save instance = null;

	private void Awake()
	{
		DontDestroyOnLoad(gameObject);
		instance = this;
	}

	// Use this for initialization
	void Start()
	{
		StartCoroutine(Init());
	}

	private void Update()
	{
		// GameObject형 변수가 true냐고 묻는것은 오브젝트가 연결이 됬냐고 묻는것과 같다.
		//if (FirstAid1 == true)
		//	FirstAid1.GetComponent<SpriteRenderer>().enabled = true;
		//if (FirstAid2 == true)
		//	FirstAid2.GetComponent<SpriteRenderer>().enabled = true;

		if (SaveFirstAid1 == true)
			FirstAid1.GetComponent<SpriteRenderer>().enabled = true;
		if (SaveFirstAid2 == true)
			FirstAid2.GetComponent<SpriteRenderer>().enabled = true;

		//if (scenemanager.getactivescene().name == "road")
		//{
		//	firstaid1 = gameobject.find("firstaid1");
		//	firstaid2 = gameobject.find("firstaid2");
		//	hp = gameobject.find("hpimage");
		//	debug.log("바보");
		//}
	}

	//void SaveHP(float HP)
	//{
	//	Savehp = HP;
	//}

	IEnumerator Init()
	{
		while (true)
		{
			yield return new WaitForSeconds(0.2f);
			FirstAid1 = GameObject.Find("FirstAid1");
			FirstAid2 = GameObject.Find("FirstAid2");
			hp = GameObject.Find("HPImage");

			if (SaveFirstAid1 == true)
				FirstAid1.GetComponent<SpriteRenderer>().enabled = true;
			if (SaveFirstAid2 == true)
				FirstAid2.GetComponent<SpriteRenderer>().enabled = true;
			//Savehp = HP;
		}
	}
}
