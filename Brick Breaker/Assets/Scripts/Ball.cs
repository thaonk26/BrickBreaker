﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Paddle paddle;
    private Vector3 paddleToBallVector;
    bool hasStarted = false;
    bool start = false;

	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
        

	}
	void OnCollisionEnter2D(Collision2D col)
    {
        if (start)
        {
            GetComponent<AudioSource>().Play();

        }
    }
	// Update is called once per frame
	void Update () {
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;

        if (Input.GetMouseButtonDown(0))
        {
                start = true;
                hasStarted = true;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 12f);
        }
        }
	}
}
