using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class START : MonoBehaviour {

    GameObject canvas;
    GameObject Event;
    GameObject[] objects;
    bool enable = false;

    private void Awake()
    {
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
        }
    }

    void OnMouseDown()
    {
        enable = true;
    }
}
