using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool isPaused = false;

    public int[] targetEnemyAmount;
    public EnemyManager enemyManager;
    private int currentLevelIndex;

	// Use this for initialization
	void Start () {
        currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
        enemyManager = GameObject.Find("EnemyManager").GetComponent<EnemyManager>();
        isPaused = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (currentLevelIndex >= targetEnemyAmount.Length)
        {
            return;
        }

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

        if (enemyManager.totalKilledEnemiesAmount >= targetEnemyAmount[currentLevelIndex])
        {
            SceneManager.LoadScene((currentLevelIndex + 1) % SceneManager.sceneCountInBuildSettings);
        }
    }
}
