using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasValve : MonoBehaviour {

    GameObject obj;
    bool enable = false;

	private void Awake()
	{
		System.GC.Collect();
	}

	// Use this for initialization
	void Start () {
        obj = GameObject.Find("GasPipe");
	}
	
	// Update is called once per frame

    void Enable()
    {
		obj.SendMessage("setValveRotate", SendMessageOptions.DontRequireReceiver);
	}
}
