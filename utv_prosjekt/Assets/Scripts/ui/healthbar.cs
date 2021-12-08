using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{

    Image healthBar;
    float maxHealth = 300f;
    float health;
    

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;
        healthBar.fillAmount = 0;         
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Reset");
        if(health == 299)
        {
            healthBar.fillAmount = 1;
        }
        if(health < 299)
        {
            healthBar.fillAmount = health / maxHealth;        
        }
        if (health == 0)
        {
            Destroy(gameObject);
        }    
    }
    IEnumerator Reset() {
        yield return new WaitForSeconds(25);
        GameObject thePlayer = GameObject.Find("b0ss(Clone)");
        bossoneHP playerScript = thePlayer.GetComponent<bossoneHP>();
        health = playerScript.HP;
        

    } 
}
