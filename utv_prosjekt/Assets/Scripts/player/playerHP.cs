using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHP : MonoBehaviour
{

    public Rigidbody2D rigid;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag=="Enemy")
        {
            ded();
            Debug.Log("collision detected");

        } 
    }

    void ded()
    {
        Debug.Log("yep, ded");

        GameManager.IsInputEnabled = false;
        rigid.constraints = RigidbodyConstraints2D.FreezeAll;
        animator.Play("dethanimation");

    }
}
