using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b0ssshoot : MonoBehaviour
{
    [SerializeField]
    private int bulletsAmount = 10;
    [SerializeField]    
    private int bulletsAmount2 = 10;
    


    [SerializeField]
    private float startAngle = 90f, endAngle = 270f;


    private Vector2 bulletMoveDirection;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
        
    }

    private void Fire()
    {
        float angleStep = (endAngle - startAngle) / bulletsAmount;
        float angle = startAngle;

        for (int i = 0; i < bulletsAmount + 1; i++)
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

    private void Fire2()
    {
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

    IEnumerator ExampleCoroutine()
    {
        InvokeRepeating("Fire", 0f, 2f);
        yield return new WaitForSeconds(10);
        CancelInvoke();
        yield return new WaitForSeconds(2);
        InvokeRepeating("Fire2", 0f, 0.5f);
        yield return new WaitForSeconds(10);
        CancelInvoke();
        yield return new WaitForSeconds(2);
        InvokeRepeating("Fire", 0f, 2f);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
