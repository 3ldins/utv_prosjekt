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

    private void OnTriggerEnter2D(Collider2D otherBoxCollider2D)
    {
        if (boxCollider2D == otherBoxCollider2D)
        {
            Destroy(gameObject);
        }
    }


}
