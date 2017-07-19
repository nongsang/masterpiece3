using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakerCover : MonoBehaviour {

    bool setRotation = false;
    public float rotationSpeed = 100.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (setRotation)
        {
            transform.rotation *= Quaternion.Euler(Vector3.left * rotationSpeed * Time.deltaTime);
            if(transform.rotation.y <= 0.1)
            {
                setRotation = false;
            }
        }
	}

    private void OnMouseDown()
    {
        setRotation = true;
    }
}
