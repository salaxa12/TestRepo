using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class menuScoreboard : MonoBehaviour
{
    public string highScoreName;
    public int highScore;
    public TMP_Text scoreBoard;


    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore");
        highScoreName = PlayerPrefs.GetString("highScoreName");
        scoreBoard.text = "Best Score: " + highScoreName + " : " + highScore;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
