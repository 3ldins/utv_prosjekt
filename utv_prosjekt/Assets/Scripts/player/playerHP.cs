using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class playerHP : MonoBehaviour
{

    public Rigidbody2D rigid;
    public Animator animator;
    public int lives = 5;
    public bool ded = false;
    public GameObject PLAYERobj;
    public string gameover;


    [SerializeField] TextMeshProUGUI livesText;

    // Start is called before the first frame update
    void Start()
    {
        livesText = GameObject.Find("floatLIVES").GetComponent<TextMeshProUGUI>();
        livesText.text = lives.ToString();
        animator.Play("playernewlife");

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(lives);
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag=="Enemy" && !ded)
        {
            lives -= 1;
            PLAYERobj.GetComponent<Animator> ().Play ("playernewlifeTEST");
            Debug.Log("respawn");


            if (lives <= 0){
                Ded();
            }
            Debug.Log("collision detected");
            livesText.text = lives.ToString();
            animator.Play("dethanimation");


        } 
    }

    void Ded()
    {
        Debug.Log("yep, ded");
        animator.Play("dethanimation");
        ded = true;
        lives = 0;
        SceneManager.LoadScene(gameover);
        

        GameManager.IsInputEnabled = false;
        rigid.constraints = RigidbodyConstraints2D.FreezeAll;


    }

    
}
