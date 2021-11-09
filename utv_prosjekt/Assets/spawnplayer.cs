using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnplayer : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public float sec = 1f;


    // Start is called before the first frame update
    void Start()
    {
        player1.SetActive(true);
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
        yield return new WaitForSeconds(sec);
        player2.SetActive(true);

    }
}
