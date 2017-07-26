﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoBlack : MonoBehaviour
{

    Image goBlack;
    private float fade = 1.0f;
    public float time = 6.0f;

    bool black = false;

    private void Awake()
    {
        goBlack = GetComponent<Image>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (black)
            Black();
    }

    void Black()
    {
        time -= 1.0f * Time.deltaTime;
        if (time > 2.0f && time < 5.5f)
            goBlack.color = new Color(0, 0, 0, fade);
        else if (time <= 2.0f)
        {
            fade -= 1.0f * Time.deltaTime;
            goBlack.color = new Color(0, 0, 0, fade);
        }
    }

    void Switch()
    {
        black = true;
    }
}