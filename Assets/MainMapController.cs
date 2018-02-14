using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMapController : MonoBehaviour {

    public GameManager gameManager;
    public EnemyManager enemyManager;
    public GameObject image;
    public GameObject button;
    public Text enemyCounter;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        enemyManager = GameObject.Find("EnemyManager").GetComponent<EnemyManager>();
        gameManager.isPaused = true;
        enemyCounter.enabled = false;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        enemyCounter.text = enemyManager.totalKilledEnemiesAmount.ToString();
    }

    public void StartGame()
    {
        gameManager.isPaused = false;
        enemyCounter.enabled = true;
        image.SetActive(false);
        button.SetActive(false);
    }
}
