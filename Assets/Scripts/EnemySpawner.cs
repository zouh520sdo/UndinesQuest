using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public Enemy.EnemyType spawnType;
    public float spawnInterval;

    public GameObject[] enemyPrefabs;

    private float timestamp;
    private SpriteRenderer sprite;

    void Awake()
    {
        tag = "Spawner";
        sprite = GetComponent<SpriteRenderer>();
        sprite.enabled = false;
    }

    // Use this for initialization
    void Start () {
        timestamp = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - timestamp > spawnInterval)
        {
            // Spawn
            Spawn();
            timestamp = Time.time;
        }
	}

    void Spawn ()
    {
        switch (spawnType)
        {
            case Enemy.EnemyType.Bacteria:
                Instantiate(enemyPrefabs[0], transform.position, Quaternion.identity);
                break;
            case Enemy.EnemyType.Sediment:
                Instantiate(enemyPrefabs[1], transform.position, Quaternion.identity);
                break;
            case Enemy.EnemyType.Chemicals:
                Instantiate(enemyPrefabs[2], transform.position, Quaternion.identity);
                break;
            case Enemy.EnemyType.Nuclear:
                Instantiate(enemyPrefabs[3], transform.position, Quaternion.identity);
                break;
        }
    }
}
