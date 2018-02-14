using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool isPaused = false;

    public int[] targetEnemyAmount;
    public EnemyManager enemyManager;
    private int currentLevelIndex;

    private AudioSource audio;
	// Use this for initialization
	void Start () {
        currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
        enemyManager = GameObject.Find("EnemyManager").GetComponent<EnemyManager>();
        audio = GetComponent<AudioSource>();

        audio.Play();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("p"))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }

        if (currentLevelIndex >= targetEnemyAmount.Length)
        {
            return;
        }

        if (enemyManager.totalKilledEnemiesAmount >= targetEnemyAmount[currentLevelIndex])
        {
            SceneManager.LoadScene((currentLevelIndex + 1) % SceneManager.sceneCountInBuildSettings);
        }
    }
}
