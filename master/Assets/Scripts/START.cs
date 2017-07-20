using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class START : MonoBehaviour {

    MeshRenderer mesh;
    bool enable = false;

    private void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (enable)
            mesh.enabled = false;
    }

    void OnMouseDown()
    {
        enable = true;
    }
}
