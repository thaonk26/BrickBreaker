using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public AudioClip crack;
    public Sprite[] hitSprites;
    private int timesHit;
    private LevelManager levelManager;
    public static int breakableCount;
    private bool isBreakable;

	// Use this for initialization
    void Awake()
    {
        breakableCount = 0;
    }
	void Start () {
        
        timesHit = 0;
         isBreakable = (this.tag == "Breakable");
        if (isBreakable)
        {
            breakableCount++;

        }
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        print("breakable initial count: " + breakableCount);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(crack, Camera.main.transform.position);
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
            breakableCount--;
            Destroy(gameObject);
            levelManager.BrickDestryoed();
            print(breakableCount);
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
