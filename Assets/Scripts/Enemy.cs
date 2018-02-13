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

    public float health;
    public float damage;
    public EnemyType type;
    public GameObject player;
    public float lifeTime;  // -1 for infinite time

    // Use for initialing before Start
    void Awake()
    {
        tag = "Enemy";
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
