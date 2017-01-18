using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for: " + name);
        //Application.LoadLevel(name);
        SceneManager.LoadScene(name);
    }
    public void QuitRequest()
    {
        Debug.Log("Level quit");
        Application.Quit();
    }
    public void BrickDestryoed()
    {
        if (Brick.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }
    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
        
    }
}
