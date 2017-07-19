using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EleDoorLeft2 : MonoBehaviour {

    public float doorSpeed = 1.0f;
    int doorState = 3;
    //0일때는 문이 닫혀있음 1은 문이 열리는 중 2는 문이 열려있음 3은 문이 닫히는 중

    //왼쪽문이 닫혀있을 때의 X좌표는 -4.26 // -0.609
    //열려있을 때의 X좌표는 -5.82 // -0.8314

    GameObject panal;

    // Use this for initialization
    void Start()
    {
        //Debug.Log(transform.position.x);
        panal = GameObject.Find("FirstPersonCharacter");
    }

    // Update is called once per frame
    void Update()
    {
        if (doorState == 3)
        {
            //transform.position += new Vector3(-1 * doorSpeed * Time.deltaTime, 0, 0);
            transform.Translate(Vector3.right * doorSpeed * Time.deltaTime);
            if (transform.position.x >= -4.26)
            {
                doorState++;
                panal.SendMessage("setFadeOut", SendMessageOptions.DontRequireReceiver);
            }
            //Debug.Log(transform.position.x);
        }
    }
}
