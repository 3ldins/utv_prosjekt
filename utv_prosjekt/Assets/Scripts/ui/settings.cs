using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;

public class settings : MonoBehaviour
{
    public string mainmenu;
    public GameObject savedtext;
    public GameObject settingsparent;
    public AudioMixer audioMixer;
    public Slider mslider;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        mslider.value = PlayerPrefs.GetFloat("volume");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.Save();
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

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("mastervolume", Mathf.Log10 (volume) * 20 );        
        PlayerPrefs.SetFloat("volume", volume);        
    }
}
