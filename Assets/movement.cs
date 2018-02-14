using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public float speed;
    public float shieldcd = 0.1f;
    public float pencd = 2f;
    private float ospeed;
    public GameObject bullet;
    public GameObject sword;
    public GameObject pentagon;
    public GameObject shieldsp;
    public float firerate = 0.2f;
    private float fire = 0f;
    private float cd = 0f;
    private float pcd = 0f;
    public CircleCollider2D col;
    public bool b=true;
    public bool sw=true;
    public bool p = true;
    public bool s = true;
    public float shieldcurrentcd()
    {
        return cd;
    }
    public float pentacurrentcd()
    {
        return pcd;
    }
    
    public static bool notpen = true;
    public static bool notshield = true;
    // Use this for initialization
    void Start () {
        ospeed = speed;
        pentagon.SetActive(false);
        col.enabled = false;
        shieldsp.SetActive(false);
        fire = firerate;
        cd = shieldcd;
        pcd = pencd;
    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        fire += Time.deltaTime;
        cd+= Time.deltaTime;
        pcd+= Time.deltaTime;
        if (fire>=firerate) fire = firerate;
        if (cd >= shieldcd) cd = shieldcd;
        if (pcd >= pencd) pcd = pencd;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        
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
        if (Input.GetKey("j") && fire >= firerate && b && notpen && notshield)
        {
            Instantiate(bullet, transform.position + (Vector3)moveDirection.normalized, Quaternion.AngleAxis(angle, Vector3.forward));
            fire = 0;
        }
        else if (Input.GetKey("l") && fire >= firerate && sw && notpen && notshield)
        {
            Instantiate(sword, transform.position + (Vector3)moveDirection.normalized * 1.2f, Quaternion.AngleAxis(angle, Vector3.forward));
            fire = 0;
        }
        else if (Input.GetKey("k") && pcd >= pencd && p && notshield)
        {
            notpen = false;
            pentagon.GetComponent<penta>().active();
        }
        else if (Input.GetKeyUp("k") && pcd >= pencd && p && notshield) { notpen = true; pentagon.GetComponent<penta>().deactive(); pcd = 0f; }
        else if (Input.GetKey("i") && cd >= shieldcd && s)
        {
            notshield = false;
            shieldsp.SetActive(true);
            col.enabled = true;
        }
        else if (Input.GetKeyUp("i") && cd >= shieldcd && s)
        {
            notshield = true;
            shieldsp.SetActive(false);
            col.enabled = false;
            cd = 0f;
        }
    }

        
}
