using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playershootin : MonoBehaviour
{

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float bulletSpeed = 15;
    [SerializeField] float bulletFiringPeriod = 0.1f;

    Coroutine fireCoroutine;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fireCoroutine = StartCoroutine(FireContinously());
        }
        if (Input.GetButtonUp("Fire1"))
        {
            StopCoroutine(fireCoroutine);
        }
    }

    private IEnumerator FireContinously()
    {
        while (true)
        {
            var bulletPos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 1);
            GameObject bullet = Instantiate(bulletPrefab, bulletPos, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(-2, bulletSpeed);
            yield return new WaitForSeconds(bulletFiringPeriod);
        }
    }


}
