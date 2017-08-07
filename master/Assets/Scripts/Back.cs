using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BACK : MonoBehaviour {

    GameObject start, credit, back;

    private void Awake()
    {
        start = GameObject.Find("START");
        credit = GameObject.Find("CREDIT");
        back = GameObject.Find("BACK");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Switch()
    {
        back.GetComponent<MeshRenderer>().enabled = true;
        back.GetComponent<MeshCollider>().enabled = true;
    }

    private void Enable()
    {
        back.GetComponent<MeshRenderer>().enabled = false;
        back.GetComponent<MeshCollider>().enabled = false;
        start.SendMessage("Switch", SendMessageOptions.DontRequireReceiver);
        credit.SendMessage("Switch", SendMessageOptions.DontRequireReceiver);
    }
}
