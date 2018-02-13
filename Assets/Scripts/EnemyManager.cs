using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public List<GameObject> enemyList;
    public List<EnemySpawner> spawnerList;
    [SerializeField]
    public Dictionary<Enemy.EnemyType, int> killedEnemiesAmount;
    [SerializeField]
    public int totalKilledEnemiesAmount { get { return getTotalKilledEnemiesAmount(); } }

    void Awake()
    {
        enemyList = new List<GameObject>();
        spawnerList = new List<EnemySpawner>();
        killedEnemiesAmount = new Dictionary<Enemy.EnemyType, int>();
        killedEnemiesAmount[Enemy.EnemyType.Bacteria] = 0;
        killedEnemiesAmount[Enemy.EnemyType.Chemicals] = 0;
        killedEnemiesAmount[Enemy.EnemyType.Nuclear] = 0;
        killedEnemiesAmount[Enemy.EnemyType.Sediment] = 0;
    }

    // Use this for initialization
    void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {
        print(totalKilledEnemiesAmount);
	}

    public void addKilledEnemiesAmount(int i, Enemy.EnemyType type)
    {
        killedEnemiesAmount[type]++;
    }

    public int getTotalKilledEnemiesAmount()
    {
        int sum = 0;
        foreach (Enemy.EnemyType e in killedEnemiesAmount.Keys)
        {
            sum += killedEnemiesAmount[e];
        }
        return sum;
    }
}
