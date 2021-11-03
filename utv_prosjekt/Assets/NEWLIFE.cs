using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWLIFE : MonoBehaviour
{

        public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator.Play("playernewlifeTEST");

    }

    // Update is called once per frame
    void Update()
    {
//        if (GameObject.Find("PlayerSprite").GetComponent<playerHP>().lives == 4){
//                animator.Play("playernewlifeTEST");
//                Debug.Log("respawn");
//            }
    }
}
