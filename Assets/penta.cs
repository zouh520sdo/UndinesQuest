using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class penta : MonoBehaviour {
    public float speed =10f;
    public GameObject destroyer;
    private GameObject parent;
    private bool anything = false;
	// Use this for initialization
	void Start () {
        

    }
    

    // Update is called once per frame
    void Update () {
        if (gameObject.transform.parent.gameObject != null)
            parent = gameObject.transform.parent.gameObject;

        Debug.Log("key");
           Vector2 moveDirection = new Vector2(0, 0);

           moveDirection.y = Input.GetAxisRaw("Vertical");
           moveDirection.x = Input.GetAxisRaw("Horizontal");
           //Debug.Log(Quaternion.LookRotation(moveDirection.normalized));
           transform.Translate(moveDirection * speed * Time.deltaTime);

        
    }
    


    public void active()
    {
        gameObject.SetActive(true);
    }
    public void deactive()
    {
        if (parent != null)
        {
            GameObject temp = Instantiate(destroyer, transform.position, transform.rotation);
            temp.transform.localScale = transform.lossyScale; gameObject.transform.position = parent.transform.position;
        }
        else return;
        
        gameObject.SetActive(false);
    }
}
