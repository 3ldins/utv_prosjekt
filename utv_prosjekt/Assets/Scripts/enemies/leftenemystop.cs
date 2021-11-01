using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftenemystop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if(rb.position.x>4.5)
            Destroy(gameObject);
    }
}
