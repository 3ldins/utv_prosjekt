using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class playerHP : MonoBehaviour
{

    public Rigidbody2D rigid;
    public Animator animator;
    public int lives = 100;
    public bool ded = false;
    public GameObject PLAYERobj;
    public string gameover;
    GameObject gameObjectToMove;





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
//        if (lives == 4){
//            transform.position = new Vector3(0.04f,-7.23f,0.89f);
//            animator.Play("playernewlife2");
//        }
//        if (lives == 3){
//            transform.position = new Vector3(0.04f,-7.23f,0.89f);
//            animator.Play("playernewlife3");
//        }
//        if (lives == 2){
//            transform.position = new Vector3(0.04f,-7.23f,0.89f);
//            animator.Play("playernewlife4");
//        }
//        if (lives == 1){
//            transform.position = new Vector3(0.04f,-7.23f,0.89f);
//            animator.Play("playernewlife5");
//        }



    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag=="Enemy" && !ded)
        {
            //animator.Play("dethanimation");
            //animator.enabled = false;
            //gameObject.GetComponent<SpriteRenderer>().enabled = false;
            //Destroy( gameObject, 1 );

            
            lives -= 5;
            //PLAYERobj.GetComponent<Animator> ().Play ("playernewlifeTEST");
            //Debug.Log("respawn");


            if (lives == 0){
                Ded();
        
                GameManager.IsInputEnabled = false;
            rigid.constraints = RigidbodyConstraints2D.FreezeAll;

            }
            livesText.text = lives.ToString();
            

        } 
    }

    void Ded()
    {
        Debug.Log("yep, ded");
        ded = true;
        lives = 0;
        animator.Play("dethanimation");
        animator.enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;

        StartCoroutine(ExampleCoroutine());


    }

    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(gameover);
        

    }

    
}
