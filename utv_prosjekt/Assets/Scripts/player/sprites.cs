using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprites : MonoBehaviour
{

    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
    }
}
