﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakerSwitch2 : MonoBehaviour
{

    bool setRotation, enable = false;
    public GameObject ES;

	private void Awake()
	{
		System.GC.Collect();
	}

	// Use this for initialization
	void Start()
    {
        //Debug.Log(transform.rotation.z);
        ES = GameObject.Find("EventSwitch");
    }

    // Update is called once per frame
    void Update()
    {
        if (setRotation && enable)
        {
            transform.rotation *= Quaternion.Euler(Vector3.back * 200.0f * Time.deltaTime);
            //Debug.Log(transform.rotation.z);
            if (transform.rotation.z <= -0.5)
                setRotation = false;
            ES.SendMessage("SetBreakerSwitch2", SendMessageOptions.DontRequireReceiver);
        }
    }

    private void SetRotate()
    {
        setRotation = true;
    }

    void Switch()
    {
        enable = true;
    }
}
