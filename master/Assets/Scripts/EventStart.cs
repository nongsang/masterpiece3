using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventStart : MonoBehaviour {

	GameObject Camera;
	GameObject NPC1;
	GameObject[] NPC2;
	BoxCollider tr;

    private void Awake()
    {
        tr = GetComponent<BoxCollider>();
        Camera = GameObject.Find("FirstPersonCharacter");
        NPC1 = GameObject.FindGameObjectWithTag("NPC1");
        NPC2 = GameObject.FindGameObjectsWithTag("NPC2");
    }

    // Use this for initialization
    void Start () {
		//tr = GetComponent<BoxCollider>();
		//Camera = GameObject.Find("FirstPersonCharacter");
		//NPC1 = GameObject.FindGameObjectWithTag("NPC1");
		//NPC2 = GameObject.FindGameObjectsWithTag("NPC2");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			StartCoroutine(EStart());
			tr.enabled = false;
		}
	}

	IEnumerator EStart()
	{
		yield return new WaitForSeconds(10.0f);
		Camera.SendMessage("EStart", SendMessageOptions.DontRequireReceiver);
		yield return new WaitForSeconds(1.0f);
		NPC1.SendMessage("Switch", SendMessageOptions.DontRequireReceiver);
		foreach (GameObject npc2 in NPC2)
			npc2.SendMessage("Switch", SendMessageOptions.DontRequireReceiver);
	}
}
