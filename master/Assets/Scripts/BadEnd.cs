using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BadEnd : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void Start () {
		Player.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
		if (other.tag == "Player")
		{
			SceneManager.LoadScene("BadEnd");
			other.transform.position = new Vector3(-3.6f, 1.52f, -14.0f);
		}
    }
}
