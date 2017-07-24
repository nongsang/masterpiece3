using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CREDIT : MonoBehaviour {

    GameObject start, credit;

    private void Awake()
    {
        start = GameObject.Find("START");
        credit = GameObject.Find("CREDIT");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
