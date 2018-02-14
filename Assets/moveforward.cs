using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveforward : MonoBehaviour {
    public float speed;
    public float life = 4f;
    private float lifetime = 0;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        lifetime += Time.deltaTime;
        if (lifetime >= life) { Destroy(gameObject); }
        transform.position += transform.right * Time.deltaTime * speed;

	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Enemy>() == null) return;
        if (gameObject.tag == "sword")
        {
            if (collision.gameObject.GetComponent<Enemy>().type == Enemy.EnemyType.Sediment)
            {
                Debug.Log("melee hit");
                collision.gameObject.GetComponent<Enemy>().TakeDamage(1000f);
            }

        }
        if (gameObject.tag == "projectile")
        {
            if (collision.gameObject.GetComponent<Enemy>().type == Enemy.EnemyType.Bacteria)
            {
                Debug.Log("range hit");
                collision.gameObject.GetComponent<Enemy>().TakeDamage(1000f);
                Destroy(gameObject);
            }

        }
        
    }
    
    
}
