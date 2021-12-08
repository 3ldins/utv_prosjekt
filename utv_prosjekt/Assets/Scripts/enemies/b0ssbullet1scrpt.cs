using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b0ssbullet1scrpt : MonoBehaviour
{
    private Vector2 moveDirection;
    private float moveSpeed;

    private void OnEnable()
    {
        Invoke("Destroy", 3f);
    }
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f; //setter movespeed til en bestemt fart som da er 5 i float value
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //if(rb.position.y<-6)
            //Destroy(gameObject);
        
        //if(rb.position.y>6)
            //Destroy(gameObject);        
    }

    public void SetMoveDirection(Vector2 dir)
    {
        moveDirection = dir;
    }

    private void Destroy()
    {
        gameObject.SetActive(false); //når Destroy blir kjørt så blir gameobjectet deaktivert
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag=="Player")
        {
            gameObject.SetActive(false); //når skuddet kolliderer med spilleren forsvinner den
        }
 }
}
