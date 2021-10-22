using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolletscript : MonoBehaviour
{

    private BoxCollider2D boxCollider2D;


    void Start()
    {
        boxCollider2D = GameObject.Find("buileltestop").GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Debug.Log(rb.velocity.y);
        if(rb.velocity.y==0)
            Destroy(gameObject);

    }

    private void OnTriggerEnter2D(Collider2D otherBoxCollider2D)
    {
        if (boxCollider2D == otherBoxCollider2D)
        {
            Destroy(gameObject);
        }

    }


}
