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
	Transform tr;

    void Awake()
    {
		System.GC.Collect();
		if (camTransform == null)
        {
            camTransform = GetComponent<Transform>();
        }
        gO = GameObject.FindGameObjectsWithTag("OBJECT");
		gD = GameObject.FindGameObjectsWithTag("DESK");
		tr = GetComponent<Transform>();
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
		Debug.DrawRay(tr.position, tr.forward * 3.0f, Color.green);
		if (Input.GetButtonDown("Fire1"))
		{
			RaycastHit hit;

			if (Physics.Raycast(tr.position, tr.forward, out hit, 6.0f))
			{
				if (hit.collider.name == "START")
					hit.collider.gameObject.SendMessage("Enable", SendMessageOptions.DontRequireReceiver);
				else if (hit.collider.name == "CREDIT")
					hit.collider.gameObject.SendMessage("Enable", SendMessageOptions.DontRequireReceiver);
				else if (hit.collider.name == "BACK")
					hit.collider.gameObject.SendMessage("Enable", SendMessageOptions.DontRequireReceiver);
				else if (hit.collider.name == "GasValve")
					hit.collider.gameObject.SendMessage("Enable", SendMessageOptions.DontRequireReceiver);
				else if (hit.collider.name == "Cover")
					hit.collider.gameObject.SendMessage("SetRotate", SendMessageOptions.DontRequireReceiver);
				else if (hit.collider.name == "breakerSwitch1")
					hit.collider.gameObject.SendMessage("SetRotate", SendMessageOptions.DontRequireReceiver);
				else if (hit.collider.name == "breakerSwitch2")
					hit.collider.gameObject.SendMessage("SetRotate", SendMessageOptions.DontRequireReceiver);
				else if (hit.collider.name == "breakerSwitch3")
					hit.collider.gameObject.SendMessage("SetRotate", SendMessageOptions.DontRequireReceiver);
				else if (hit.collider.name == "firstAidBox")
					Destroy(hit.collider.gameObject);
				else if (hit.collider.name == "ElevatorButton")
					hit.collider.gameObject.SendMessage("Switch", SendMessageOptions.DontRequireReceiver);
			}
		}
		if (shake > 0)
        {
            camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
			if (shakeAmount == 0.7f)
			{
				foreach (GameObject o in gO)
					o.SendMessage("Earthquake", SendMessageOptions.DontRequireReceiver);
				foreach (GameObject d in gD)
				{
					d.SendMessage("Earthquake", SendMessageOptions.DontRequireReceiver);
					d.GetComponent<Rigidbody>().isKinematic = false;
				}
			}
			else
			{
				foreach (GameObject o in gO)
					o.SendMessage("EStart", SendMessageOptions.DontRequireReceiver);
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
