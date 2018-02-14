using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMapController : MonoBehaviour {

    public GameManager gameManager;
    public GameObject canvas;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.isPaused = true;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
        gameManager.isPaused = false;
        canvas.SetActive(false);
    }
}
