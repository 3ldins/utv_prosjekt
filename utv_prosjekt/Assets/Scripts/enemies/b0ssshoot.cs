using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b0ssshoot : MonoBehaviour
{
    [SerializeField]
    private int bulletsAmount = 10;
    [SerializeField]    
    private int bulletsAmount2 = 10;

    public AudioSource shootAudio;

    [SerializeField]
    private float startAngle = 90f, endAngle = 270f; //her er det serializefield som gjør at jeg kan lett endre på mønstret til bossen, altså hvordan han skyter


    private Vector2 bulletMoveDirection;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine()); //når bossen blir aktivert så begynner denne skripten rett under med engang.
    }

    IEnumerator ExampleCoroutine()
    {
        InvokeRepeating("Fire", 0f, 2f); //utløser "Fire" skriptet
        yield return new WaitForSeconds(10); //venter 10 sekund
        CancelInvoke(); //stopper "Fire" skriptet
        yield return new WaitForSeconds(2); //venter 2 sekund
        InvokeRepeating("Fire2", 0f, 0.5f); // starter "Fire2" skriptet som er det andre skyte mønstret
        yield return new WaitForSeconds(10); //repeat
        CancelInvoke();
        yield return new WaitForSeconds(2);
        InvokeRepeating("Fire", 0f, 2f);

    }

    private void Fire()
    {
        shootAudio.Play(0); //spiller en lyd som indikerer at den skyter
        
        float angleStep = (endAngle - startAngle) / bulletsAmount; //deler opp skuffene slik at det er like mye rom mellom dem i sirkelen
        float angle = startAngle;

        for (int i = 0; i < bulletsAmount + 1; i++) //hvis i er mindre enn bulletsamount så kjører skripter under, dette passer på at skuddene har kontroll og at alle ikke skyter på en gang
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f); //masse matte som deler opp skuddene slik at den skyter i et fint mønster basert på nummerene

            Vector3 bulMoveVector = new Vector3(bulDirX,  bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstanse.GetBullet(); //får inn bullet prefabben
                bul.transform.position = transform.position; 
                bul.transform.rotation = transform.rotation; //disse to forteller hvilken posisjon og rotasjon bulleten skal ha
                bul.SetActive(true);
                bul.GetComponent<b0ssbullet1scrpt>().SetMoveDirection(bulDir);

            angle += angleStep;
        }
    }

    private void Fire2() //samme som "Fire" men endret litt på mønsteret for å lage variasjon
    {
        shootAudio.Play(0);
                
        float angleStep = (endAngle - startAngle) / bulletsAmount2;
        float angle = startAngle;

        for (int i = 0; i < bulletsAmount2 + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX,  bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstanse.GetBullet();
                bul.transform.position = transform.position;
                bul.transform.rotation = transform.rotation;
                bul.SetActive(true);
                bul.GetComponent<b0ssbullet1scrpt>().SetMoveDirection(bulDir);

            angle += angleStep;
        }
    }
}
