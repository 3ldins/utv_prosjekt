using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour
{

    public static bool IsInputEnabled = false;
    public GameObject pasuemenu;
    public string winnerscene;
    private GameObject scriptholder;
    public float hpFLoat;


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
        AudioListener.pause = false;

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

        scriptholder = GameObject.FindGameObjectWithTag("Enemy");
    	hpFLoat = scriptholder.GetComponent<bossoneHP>().HP;


        if (hpFLoat <= 0)
        {
            StartCoroutine(LoadEnding());
        }
    }

    IEnumerator LoadEnding()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(winnerscene);
        Debug.Log("ending");
        
    }


    void Pause()
    {
        pasuemenu.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.pause = true;
    }
}
