using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

    private Transform camTransform;
    private GameObject[] gO;
	private GameObject[] gD;
    public float shake = 0.0f;

    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1.0f;

    Vector3 originalPos;

    void Awake()
    {
        if (camTransform == null)
        {
            camTransform = GetComponent<Transform>();
        }
        gO = GameObject.FindGameObjectsWithTag("OBJECT");
		gD = GameObject.FindGameObjectsWithTag("DESK");
    }

    void OnEnable()
    {
        originalPos = camTransform.localPosition;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (shake > 0)
        {
            camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
			if (shakeAmount == 0.7f)
			{
				foreach (GameObject o in gO)
				{
					o.SendMessage("Switch", SendMessageOptions.DontRequireReceiver);
				}
				foreach (GameObject d in gD)
				{
					d.SendMessage("Switch", SendMessageOptions.DontRequireReceiver);
				}
			}
			else
			{
				foreach (GameObject o in gO)
				{
					o.SendMessage("EStart", SendMessageOptions.DontRequireReceiver);
				}
			}
            shake -= Time.deltaTime * decreaseFactor;
        }
        else
        {
            shake = 0f;
            camTransform.localPosition = originalPos;
        }
    }

    void Switch()
    {
        shake = 3.0f;
		shakeAmount = 0.7f;
    }

	void EStart()
	{
		shake = 10.0f;
		shakeAmount = 0.1f;
	}
}
