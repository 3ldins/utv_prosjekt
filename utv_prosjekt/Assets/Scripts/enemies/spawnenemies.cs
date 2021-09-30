using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemies : MonoBehaviour
{
    public GameObject SimpleEnemy;

    public void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    public IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(4f);
        StartCoroutine(SpawnSimple(SimpleEnemy, 0.35f, 10));
        yield return new WaitForSeconds(4f);
    }

    public IEnumerator SpawnSimple(GameObject gameObject, float wait, int amount)
    {
        for (int t = 0; t < amount; t++)
        {
            yield return new WaitForSeconds(wait);
            Instantiate(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
