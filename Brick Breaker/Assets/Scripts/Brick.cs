﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    public Sprite[] hitSprites;
    private int timesHit;
    private LevelManager levelManager;

	// Use this for initialization
	void Start () {
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        bool isBreakable = (this.tag == "Breakable");
        if (isBreakable)
        {

            HandleHits();
        }
       
        //if(gameObject.)
        //SimulateWin();
    }
    void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        print(spriteIndex);
        if (hitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
    }

    void HandleHits()
    {
       
        timesHit++;
        int maxHits = hitSprites.Length + 1;
        if (timesHit >= maxHits)
        {
            Destroy(gameObject);


        }
        else
        {

            LoadSprites();
        }

    }
    void SimulateWin()
    {
        levelManager.LoadNextLevel();
    }
}
