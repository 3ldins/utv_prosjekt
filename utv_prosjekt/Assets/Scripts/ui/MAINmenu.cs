using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Audio;

public class MAINmenu : MonoBehaviour
{
    public string startscene;
    public string settings;
	public Color loadToColor = Color.white;
    public TextMeshProUGUI loadingtext;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        AudioListener.pause = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Initiate.Fade(startscene, loadToColor, 0.75f);
        loadingtext.text = "loading...";
        
    }

    public void OpenOptions()
    {
        SceneManager.LoadScene(settings);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
 

}
