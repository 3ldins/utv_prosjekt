using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemies : MonoBehaviour
{
    public GameObject SimpleEnemy;
    public GameObject SimpleEnemyTWO;
    public GameObject SecondEnemy;
    public GameObject SecondEnemyTWO;
    public GameObject BossOne;


    public void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    public IEnumerator SpawnEnemies()
    {
        //yield return new WaitForSeconds(4f);
        //StartCoroutine(SpawnSimple(SimpleEnemy, 0.35f, 10));
        //yield return new WaitForSeconds(1f);
        //StartCoroutine(SpawnSimple(SimpleEnemyTWO, 0.35f, 10));
        //yield return new WaitForSeconds(6f);
        //StartCoroutine(SpawnSimple(SecondEnemy, 0.35f, 10));
        //StartCoroutine(SpawnSimple(SecondEnemyTWO, 0.35f, 10));
        //yield return new WaitForSeconds(6f);
        //StartCoroutine(SpawnSimple(SimpleEnemy, 0.35f, 10));
        //yield return new WaitForSeconds(1f);
        //StartCoroutine(SpawnSimple(SimpleEnemyTWO, 0.35f, 10));              
        yield return new WaitForSeconds(2f);
        StartCoroutine(SpawnSimple(BossOne, 0.35f, 1));                

    }

    public IEnumerator SpawnSimple(GameObject gameObject, float wait, int amount)
    {
        for (int t = 0; t < amount; t++)
        {
            yield return new WaitForSeconds(wait);
            var newEnemy = Instantiate(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
