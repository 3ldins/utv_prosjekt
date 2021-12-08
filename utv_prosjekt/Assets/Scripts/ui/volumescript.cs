using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class volumescript : MonoBehaviour
{

    public GameObject buttone;
    public float volume = 80f;
    public AudioMixer audioMixer;
    public Slider SliderValue;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject == EventSystem.current.currentSelectedGameObject)
        {

        }
    }
}
