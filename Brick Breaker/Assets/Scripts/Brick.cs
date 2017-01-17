using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    public int maxHits;
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
        timesHit++;
        Debug.Log("timesHit before: " + timesHit);
        if(timesHit >= maxHits)
        {
            Destroy(gameObject);
            Debug.Log("timesHit after: " + timesHit);

        }
        else
        {
            Debug.Log("timesHit after 2: " + timesHit);
            LoadSprites();
        }
        //if(gameObject.)
        //SimulateWin();
    }
    void LoadSprites()
    {
        
        int spriteIndex = timesHit - 1;
        print(spriteIndex);
        Debug.Log("INdex " + spriteIndex);
        this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
    }
    void SimulateWin()
    {
        levelManager.LoadNextLevel();
    }
}
