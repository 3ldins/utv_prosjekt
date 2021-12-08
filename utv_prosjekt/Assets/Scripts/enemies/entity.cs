using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entity : MonoBehaviour
{

    public float HP = 5.0f;
    public AudioClip DeathSound;
    public float DeathVolume;

    void Update() //hele dette skriptet er ganske likt bossoneHP
    {
        if (HP <= 0)
        {
            Die();
        }
    }

    public void Damage(float Damage)
    {
        HP -= Damage;
        if (HP <= 0)
        {
            Die();
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag=="PlayerBullet")
        {
            HP = HP - 5.0f;
            FindObjectOfType<scoretext>().IncreaseScore();
            Debug.Log("enemycollision");


        } 
        if(collision.gameObject.tag=="Player")
        {
            Destroy (gameObject);
        }
 }


    public virtual void Die()
    {
        Destroy(gameObject);
        PlaySound();
        Debug.Log("enemy dieded");
    }

    public void PlaySound()
    {
        if (DeathSound == null) return;
        GameObject newAC = new GameObject();
        AudioSource audioSource = newAC.AddComponent<AudioSource>();
        audioSource.volume = DeathVolume;
        audioSource.PlayOneShot(DeathSound);
        StartCoroutine(DestroyOverSeconds(DeathSound.length + 0.1f, newAC));
        DontDestroyOnLoad(newAC);
    }

    public IEnumerator DestroyOverSeconds(float time, GameObject go)
    {
        yield return new WaitForSeconds(time);
        Destroy(go);
    }
}
