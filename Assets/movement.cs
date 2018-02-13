using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public float speed;
    private float ospeed;
    public GameObject bullet;
    public GameObject sword;
    public float firerate = 0.2f;
    private float fire = 0f;
    public bool b=true;
    public bool sw=true;
    
    public static bool notpen = true;
    // Use this for initialization
    void Start () {
        ospeed = speed;
	}

    // Update is called once per frame
    private void FixedUpdate()
    {
        fire += Time.deltaTime;
        
    }
    
    void Update () {
        if (notpen == false) { speed = 0; }
        else { speed = ospeed; }
        Vector2 moveDirection = new Vector2(0, 0);
        
        moveDirection.y = Input.GetAxisRaw("Vertical");
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        //Debug.Log(Quaternion.LookRotation(moveDirection.normalized));
        transform.Translate(moveDirection * speed * Time.deltaTime);
        Vector2 moveDirection2 = moveDirection.normalized;
        float angle = Mathf.Atan2(moveDirection2.y, moveDirection2.x) * Mathf.Rad2Deg;
        if (moveDirection.x == 0 && moveDirection.y == 0) moveDirection.x = 1f;
        if (Input.GetKey("j") && fire >= 0.2f && b && notpen)
        {
            Instantiate(bullet, transform.position+ (Vector3)moveDirection.normalized, Quaternion.AngleAxis(angle, Vector3.forward));
            fire = 0;
        }
        else if (Input.GetKey("l") && fire >= 0.2f && sw && notpen)
        {
            Instantiate(sword, transform.position + (Vector3)moveDirection.normalized*1.2f, Quaternion.AngleAxis(angle, Vector3.forward));
            fire = 0;
        }
        else if (Input.GetKey("k") && fire >= 0.2f )
        {
            notpen = false;
        }
        else notpen = true;
    }
}
