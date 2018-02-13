using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public Enemy.EnemyType spawnType;
    public float spawnInterval;

    public GameObject[] enemyPrefabs;

    void Awake()
    {
        tag = "Spawner";

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
