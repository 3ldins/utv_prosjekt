using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pausemenu : MonoBehaviour
{

    public GameObject pausemenutwo;
    public string startscene;
    public string game;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        Unpause();

    }

    void Unpause()
    {
        pausemenutwo.SetActive(false);
        Time.timeScale = 1f;
        AudioListener.pause = false;
    }

    public void restart()
    {
        SceneManager.LoadScene(game);
        Time.timeScale = 1f;
    }

    public void backtomenu()
    {
        SceneManager.LoadScene(startscene);
        Time.timeScale = 1f;
        
    }

}
