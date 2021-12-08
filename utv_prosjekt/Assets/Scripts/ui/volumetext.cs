using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;

public class volumetext : MonoBehaviour
{

    public TextMeshProUGUI TextPro;
    private float volumenew;
    public AudioMixer audioMixer;

    // Update is called once per frame
    void Update()
    {
        var volumenew = GameObject.Find("btnVolume").GetComponent<volumescript>();
        TextPro.text="Volume: < "+volumenew.volume.ToString()+" >";
    }
}
