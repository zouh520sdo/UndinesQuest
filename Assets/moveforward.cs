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
}
