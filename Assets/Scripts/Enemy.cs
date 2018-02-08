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

    // Use for initialing before Start
    void Awake()
    {
        tag = "Enemy";
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
