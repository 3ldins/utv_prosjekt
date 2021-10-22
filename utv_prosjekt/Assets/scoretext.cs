using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class scoretext : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI scoreText;
    public GameObject ScriptHolder;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = ""; // To make sure the score text is accurate        
    }

    public void IncreaseScore() {
        score++;
        scoreText.text = score+"00";
    }    

    // Update is called once per frame
    void Update()
    {

    }
}
