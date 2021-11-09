using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static bool IsInputEnabled = false;


    // Start is called before the first frame update
    void Awake()
    {
        Application.targetFrameRate = 60;


    }

    void Start()
    {
        StartCoroutine(ExampleCoroutine());
        GameManager.IsInputEnabled = false;

    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1.3f);
        GameManager.IsInputEnabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        SceneManager.LoadScene(1);

    }
}
