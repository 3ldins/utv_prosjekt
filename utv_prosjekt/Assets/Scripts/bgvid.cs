using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class bgvid : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public string url;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(videoPlayer.frame == 849)
        {
            
            videoPlayer.url = url;
            videoPlayer.frame = 0;
            videoPlayer.isLooping = true;
        }
    }


}
