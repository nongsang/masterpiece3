using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoBlack : MonoBehaviour {

    public Image goBlack;

    private void Awake()
    {
        goBlack.color = new Color(0,0,0,1.0f);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
