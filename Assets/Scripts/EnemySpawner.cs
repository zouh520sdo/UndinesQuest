using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public Enemy.EnemyType spawnType;
    public float spawnInterval;
    public bool canSpawn;
    public GameObject[] enemyPrefabs;
    public EnemyManager enemyManager;

    private float timestamp;
    private SpriteRenderer sprite;

    void Awake()
    {
        tag = "Spawner";
        sprite = GetComponent<SpriteRenderer>();
        sprite.enabled = false;
        enemyManager = GameObject.Find("EnemyManager").GetComponent<EnemyManager>();
    }

    // Use this for initialization
    void Start () {
        if (enemyManager)
        {
            enemyManager.spawnerList.Add(this);
        }
        timestamp = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (canSpawn)
        {
            if (Time.time - timestamp > spawnInterval)
            {
                // Spawn
                Spawn();
                timestamp = Time.time;
            }
        }
	}

    void OnDestroy()
    {
        if (enemyManager)
        {
            enemyManager.spawnerList.Remove(this);
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
