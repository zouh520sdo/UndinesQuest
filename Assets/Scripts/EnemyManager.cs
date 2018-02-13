using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public List<GameObject> enemyList;
    

	// Use this for initialization
	void Start () {
        enemyList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Enemy"));
        foreach (GameObject go in enemyList)
        {
            print(go.name);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
