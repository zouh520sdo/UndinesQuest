using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroychem : MonoBehaviour {

    // Use this for initialization
    private float lifetime=1f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0) Destroy(gameObject);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.GetComponent<Enemy>().type == Enemy.EnemyType.Chemicals)
        {
            Debug.Log("alchem hit");
            collision.gameObject.GetComponent<Enemy>().TakeDamage(1.2f*Time.deltaTime);
            
        }
    }
}
