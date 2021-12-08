using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class hiscore : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI scoreText;
    public Text highScore;

    void Start()
    {
        //scoreText.text = "";
    }

    // Start is called before the first frame update
    void Update()
    {
        scoreText.text = PlayerPrefs.GetInt("highscore").ToString() + "00";
        //Debug.Log(PlayerPrefs.GetInt("highscore"));
    }
}
