using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static bool IsInputEnabled = false;
    public GameObject pasuemenu;


    // Start is called before the first frame update
    void Awake()
    {
        Application.targetFrameRate = 60;


    }

    void Start()
    {
        StartCoroutine(ExampleCoroutine());
        GameManager.IsInputEnabled = false;
        pasuemenu.SetActive(false);
        Time.timeScale = 1f;

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
        
        if(Input.GetKeyDown(KeyCode.Escape))
        Pause();

    }

    void Pause()
    {
        pasuemenu.SetActive(true);
        Time.timeScale = 0f;
    }
}
