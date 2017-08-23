using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour {

	GameObject Player;
	bool enable = true;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find("FPSController");
	}

	private void Awake()
	{
		System.GC.Collect();
	}

	// Update is called once per frame
	//void Update () {

	//}

	private void OnTriggerStay(Collider other)
	{
		if (enable == false)
			StopAllCoroutines();
		else if(other.tag == "Player")
		{
			StartCoroutine(WaitTwoSeconds());
		}
	}

	IEnumerator WaitTwoSeconds()
	{
		yield return new WaitForSeconds(2.0f);
		Player.SendMessage("OnDamage", SendMessageOptions.DontRequireReceiver);
		yield return new WaitForSeconds(2.0f);
		Player.SendMessage("OnDamage", SendMessageOptions.DontRequireReceiver);
		yield return new WaitForSeconds(2.0f);
		Player.SendMessage("OnDamage", SendMessageOptions.DontRequireReceiver);
		yield return new WaitForSeconds(2.0f);
		Player.SendMessage("OnDamage", SendMessageOptions.DontRequireReceiver);
		yield return new WaitForSeconds(2.0f);
		Player.SendMessage("OnDamage", SendMessageOptions.DontRequireReceiver);
	}
}
