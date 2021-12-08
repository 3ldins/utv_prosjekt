using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossoneHP : MonoBehaviour
{

    public float HP = 100.0f;
    public AudioClip DeathSound;
    public float DeathVolume;
    public AudioSource audioData;

    void Update()
    {
        if (HP <= 0)
        {
            Die(); //dersom HP er 0 eller mindre så kjører "Die" skriptet
        }
    }

    public void Damage(float Damage)
    {
        HP -= Damage; //Når bossen får Damage så subtraherer jeg HP med Damage floaten til playerskuddet.
        if (HP <= 0)
        {
            Die();
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag=="PlayerBullet")
        {
            HP = HP - 1.0f;
            audioData.Play(0);
            FindObjectOfType<scoretext>().IncreaseScore();
            //Debug.Log("enemycollision");
        } 

 }


    public virtual void Die()
    {
        Destroy(gameObject); //sletter bossen
        PlaySound(); //spiller av defeat lyden
        Debug.Log("enemy dieded");
    }

    public void PlaySound() //skriptet til lyden som spilles av når bossen er defeated.
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
