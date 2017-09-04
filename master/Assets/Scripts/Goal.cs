using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	public GameObject Player;
	SpriteRenderer Finish1;
	SpriteRenderer Finish2;

	bool isFinish = false;
	float fade = 0.0f;

	private void Start()
	{
		Finish1 = GameObject.Find("GoBlack1").GetComponent<SpriteRenderer>();
		Finish2 = GameObject.Find("GoBlack2").GetComponent<SpriteRenderer>();
	}

	private void Update()
	{
		if (isFinish)
			finish();
	}

	void finish()
	{
		fade += 0.5f * Time.deltaTime;
		Finish1.color = new Color(0, 0, 0, fade);
		Finish2.color = new Color(0, 0, 0, fade);
		Invoke("quit", 4.0f);
	}

	private void quit()
	{
		Application.Quit();
		Debug.Log("꺼짐");
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Debug.Log("끝");
			Player.GetComponent<CharacterController>().enabled = false;
			isFinish = true;
		}
	}
}
