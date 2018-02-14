using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraManager : MonoBehaviour {

    public GameObject player;
    public float smooth = 10f;
    private float z;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        z = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 target = player.transform.position;
        Vector3 target3 = Vector2.Lerp(transform.position, target, smooth * Time.deltaTime);
        target3.z = z;
        transform.position = target3;
	}
}
