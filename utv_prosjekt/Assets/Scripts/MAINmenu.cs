using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAINmenu : MonoBehaviour
{
    public string startscene;
	public Color loadToColor = Color.white;


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

    public void StartGame()
    {
        Initiate.Fade(startscene, loadToColor, 0.75f);

        
    }

    public void OpenOptions()
    {

    }

    public void CloseOptions()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
 

}
