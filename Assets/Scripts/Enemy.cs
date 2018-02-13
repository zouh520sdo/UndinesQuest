using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public enum EnemyType
    {
        Bacteria,
        Sediment,
        Chemicals,
        Nuclear
    }

    public float HP;
    public float damage;
    public EnemyType type;
    public GameObject player;
    public float lifeTime;  // -1 for infinite time
    public float speed;
    public EnemyManager enemyManager;

    // Use for initialing before Start
    void Awake()
    {
        tag = "Enemy";
        player = GameObject.FindGameObjectWithTag("Player");
        enemyManager = GameObject.Find("EnemyManager").GetComponent<EnemyManager>();
    }

    // Use this for initialization
    void Start () {
        if (enemyManager)
        {
            enemyManager.enemyList.Add(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		if (player)
        {
            Vector2 targetV = player.transform.position - transform.position;
            transform.Translate(targetV.normalized * speed * Time.deltaTime);
        }
	}

    void OnDestroy()
    {
        if (enemyManager)
        {
            enemyManager.enemyList.Remove(gameObject);
            enemyManager.addKilledEnemiesAmount(1, type);
        }
    }

    public void TakeDamage(float d)
    {
        HP -= d;
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
