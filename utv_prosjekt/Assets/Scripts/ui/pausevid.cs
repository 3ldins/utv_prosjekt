using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class pausevid : MonoBehaviour
{

    [SerializeField] private VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
        videoPlayer.Pause();
        }
        
    }
}
