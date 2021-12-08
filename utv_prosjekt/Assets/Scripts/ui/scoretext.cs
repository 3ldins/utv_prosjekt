using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class scoretext : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI scoreText;
    public GameObject ScriptHolder;
    public int score;
    public Text ScoreText;
    public Text ShadowScoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = ""; // To make sure the score text is accurate        
    }

    public void IncreaseScore() {
        score++;
        scoreText.text = score+"00";
        if(PlayerPrefs.GetInt("highscore")<score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }    

    // Update is called once per frame
    void Update()
    {
        
    }
}
