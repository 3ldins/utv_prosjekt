using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWLIFE : MonoBehaviour
{

        public Animator animator;
        public float seconds = 0.25f;


    // Start is called before the first frame update
    void Start()
    {
        animator.Play("playernewlifeTEST");

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("PlayerSprite").GetComponent<playerHP>().lives == 2){
                StartCoroutine(ExampleCoroutine());

            }
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(seconds);
        transform.position = new Vector3(0.0f,0.0f,0.0f);

    }
}
