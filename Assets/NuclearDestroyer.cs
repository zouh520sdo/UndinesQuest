﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuclearDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            print("asdfasdfasdfa");
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            if (enemy.type == Enemy.EnemyType.Nuclear)
            {
                Destroy(enemy.gameObject);
            }
        }
    }
}
