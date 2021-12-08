using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dethanimataioon : MonoBehaviour
{


    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("PlayerSprite").GetComponent<playerHP>().lives == 0){
                animator.Play("dethanimationPLAYER");
                Debug.Log("respawn");
            }        
    }
}
