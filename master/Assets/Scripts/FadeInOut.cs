using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeInOut : MonoBehaviour {

    public UnityEngine.UI.Image fade;   // 맨 앞의 이미지
    float fades = 0.0f; // 알파값 1 == 255, 0 ~ 1 사용가능

    float time = 0;

    bool fadeinout = false; // 스위치

    GameObject obj;

	// Use this for initialization
	void Start () {
        obj = GameObject.Find("Image");
	}
	
	// Update is called once per frame
	void Update () {

        //if (Input.GetKeyDown("space"))
        //    fadeinout = !fadeinout;

        if(fadeinout)
            FadeOut();
        else if(!fadeinout)
            FadeIn();
        if(fade.color.a >= 1)
        {
            obj.SendMessage("setImage", SendMessageOptions.DontRequireReceiver);
        }
    }
    void FadeIn()
    {
        time += Time.deltaTime;
        if(fades > 0.0f && time >= 0.1f)
        {
            fades -= 0.1f;
            fade.color = new Color(0, 0, 0, fades);
            time = 0;   // update()에서 반복하여 호출하므로
        }
    }
    void FadeOut()
    {
        time += Time.deltaTime;
        if (fades < 1.0f && time >= 0.1f)
        {
            fades += 0.1f;
            fade.color = new Color(0, 0, 0, fades);
            time = 0;   // update()에서 반복하여 호출하므로
        }
    }

    public void setFadeOut()
    {
        fadeinout = true;
        Update();
    }
}
