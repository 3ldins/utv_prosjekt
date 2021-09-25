using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showhidehitbox : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite preSprite;
    public Sprite curSprite; //disse lager variabler som jeg da kan referensere i unity og bruke i koden underfor

    // Update is called once per frame
    void Update() 
    {
        if(Input.GetKeyDown (KeyCode.LeftShift)) //når shift knappen holdes nede så endrer den sprite til den synlige spriten
        {
            spriteRenderer.sprite = curSprite;
        }
        if(Input.GetKeyUp (KeyCode.LeftShift)) //når shift knappen sleppes, endres spriten til den som er usynlig, denne ganske enkle koden laget jeg selv
        {
            spriteRenderer.sprite = preSprite;
        }
    }
}
