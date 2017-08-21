using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Died : MonoBehaviour {

    float timecost = 5.0f;
    Image im;
	bool enable = false;

	// Use this for initialization
	void Start () {
        im = GetComponent<Image>();
        im.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (enable)
        {
            timecost -= Time.deltaTime;
			if (timecost <= 3.0f)
				im.enabled = true;
            if(timecost <= 0)
                Application.Quit();
        }
	}

    void Die()
    {
        im.enabled = true;
    }

	void Enable()
	{
		enable = true;
	}
}
