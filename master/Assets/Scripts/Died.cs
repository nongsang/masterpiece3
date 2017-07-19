using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Died : MonoBehaviour {

    float timecost = 3.0f;
    Image im;

	// Use this for initialization
	void Start () {
        im = GetComponent<Image>();
        im.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (im.enabled)
        {
            timecost -= Time.deltaTime;
            if(timecost <= 0)
            {
                Application.Quit();
            }
        }
	}

    void setImage()
    {
        
        im.enabled = true;
    }
}
