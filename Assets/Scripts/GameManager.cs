using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public bool isPaused = false;

	// Use this for initialization
	void Start () {
        isPaused = false;
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("p"))
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
	}
}
