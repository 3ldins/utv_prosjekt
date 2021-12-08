using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallshooter : MonoBehaviour
{

    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;
    private Transform player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; //finner spilleren

        timeBtwShots = startTimeBtwShots; //bestemmer hvor fort fienden skyter
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        else 
        {
            timeBtwShots -= Time.deltaTime;
        }
    }

    

}
