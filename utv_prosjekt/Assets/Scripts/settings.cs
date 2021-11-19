using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class settings : MonoBehaviour
{
    public string mainmenu;
    public GameObject savedtext;
    public GameObject settingsparent;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("highscore", 0);
        Instantiate(savedtext, settingsparent.transform);
        
    }

    public void CloseOptions()
    {
        SceneManager.LoadScene(mainmenu);
    }

}
