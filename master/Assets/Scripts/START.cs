using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class START : MonoBehaviour {

    GameObject start;
    GameObject canvas;
    GameObject Event;
    GameObject[] objects;
	public GameObject damage;

	bool enable = false;

	private void Awake()
    {
		System.GC.Collect();
		start = GameObject.Find("START");
        canvas = GameObject.Find("Canvas");
        Event = GameObject.Find("EventStart");
        objects = GameObject.FindGameObjectsWithTag("OBJECT");
	}

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (enable)
        {
            Destroy(canvas);
            Event.SendMessage("Switch", SendMessageOptions.DontRequireReceiver);
            foreach (GameObject o in objects)
                o.SendMessage("Switch", SendMessageOptions.DontRequireReceiver);
			damage.SendMessage("Enable", SendMessageOptions.DontRequireReceiver);
		}
    }

	void Enable()
	{
		enable = true;
	}

	void Switch()
    {
        start.GetComponent<SpriteRenderer>().enabled = true;
        start.GetComponent<BoxCollider>().enabled = true;
    }
}
