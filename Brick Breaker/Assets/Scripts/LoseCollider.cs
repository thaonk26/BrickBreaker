using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
    private LevelManager levelManager;
	void OnCollisionEnter2D(Collision2D collision)
    {
        print("collision");
    }
    void OnTriggerEnter2D(Collider2D trigger)
    {
        print("Trigger");
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        levelManager.LoadLevel("Lose Screen");
    }
}
