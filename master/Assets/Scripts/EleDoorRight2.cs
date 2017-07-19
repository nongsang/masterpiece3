using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EleDoorRight2 : MonoBehaviour {

    public float doorSpeed = 1.0f;
    int doorState = 3;
    //0일때는 문이 닫혀있음 1은 문이 열리는 중 2는 문이 열려있음 3은 문이 닫히는 중
    //오른쪽 문이 닫혀있을 때 X 좌표는 -2.8021 // -0.4
    //열려있을 때는 -1.351 // -0.1917


    // Use this for initialization
    void Start()
    {
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        if (doorState == 3)
        {
            //transform.position += new Vector3(-1 * doorSpeed * Time.deltaTime, 0, 0);
            transform.Translate(Vector3.left * doorSpeed * Time.deltaTime);
            if (transform.position.x <= -2.8021)
            {
                doorState++;

            }
            //Debug.Log(transform.position.x);
        }
    }

    
}
