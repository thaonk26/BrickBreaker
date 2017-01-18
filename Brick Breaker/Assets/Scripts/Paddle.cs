﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public bool autoPlay = false;

    private Ball ball;

    void Start()
    {
        ball = GameObject.FindObjectOfType<Ball>();
        
    }
	void Update () {
        if (!autoPlay)
        {
            MoveWithMouse();
        }else
        {
            AutoPlay();
        }
        

	}
    void MoveWithMouse()
    {
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        Vector3 paddlePos = new Vector3(mousePosInBlocks, 0.5f, 0f);
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.6f, 15.4f);
        this.transform.position = paddlePos;
    }

    void AutoPlay()
    {
        Vector3 ballPos = ball.transform.position;
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
        paddlePos.x = Mathf.Clamp(ballPos.x, 0.6f, 15.4f);
        this.transform.position = paddlePos;
    }
}
