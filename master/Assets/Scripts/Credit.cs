using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CREDIT : MonoBehaviour {

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
    private void OnMouseDown()
    {
        start.GetComponent<MeshRenderer>().enabled = false;
        start.GetComponent<MeshCollider>().enabled = false;
        credit.GetComponent<MeshRenderer>().enabled = false;
        credit.GetComponent<MeshCollider>().enabled = false;
        back.SendMessage("Switch", SendMessageOptions.DontRequireReceiver);
    }

    void Switch()
    {
        credit.GetComponent<MeshRenderer>().enabled = true;
        credit.GetComponent<MeshCollider>().enabled = true;
    }
}
