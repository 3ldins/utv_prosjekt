using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{

    public float speed;

    public Transform target;
    private Vector3 movementVector = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

        movementVector = (target.position - transform.position).normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += movementVector * Time.deltaTime;
        
        Rigidbody2D rb = GetComponent<Rigidbody2D>();        
        if(rb.position.y<-6)
            Destroy(gameObject);
        
        if(rb.position.y>6)
            Destroy(gameObject); //sletter fienden sitt skudd dersom den går out of bounds, dette er for optimalizations
       //if(transform.position.x == target.x && transform.position.y == target.y)
       //{
       //    DestroyProjectile();
       //}
    }

    //void OnTriggerEnter2D(Collider2D other)
    //{
      //  if(other.CompareTag("Player"))
    //    {
        //    DestroyProjectile();
      //  }
    //}

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag=="Player")
        {
            Destroy (gameObject);
        }
 }

}
