using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameoverscrpt : MonoBehaviour
{

    public string startscene;
    public string menuscene;


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

    public void Restart()
    {
        SceneManager.LoadScene(startscene);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(menuscene);
    }

}
