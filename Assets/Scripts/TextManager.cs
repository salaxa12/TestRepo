using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text scoreBoard;
    public int highScore;
    public int currentScore;
    public string currentName;
    public string highScoreName;
    public MainManager mainManager;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("highScore", 0);
        PlayerPrefs.SetString("highScoreName", "none");

        mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
        highScore = PlayerPrefs.GetInt("highScore");
        highScoreName = PlayerPrefs.GetString("highScoreName");
        currentName = PlayerPrefs.GetString("name");
        
    }

    // Update is called once per frame
    void Update()
    {
        currentScore = mainManager.m_Points;
        if (currentScore > highScore)
        {
            PlayerPrefs.SetInt("highScore", currentScore);
            PlayerPrefs.SetString("highScoreName", currentName);

        }

        scoreBoard.text = "Best Score: " + highScoreName + " : " + highScore;
        //if (mainManager.m_GameOver)
        //{
        //    scoreBoard.text = "Best Score: " + highScoreName + " : " + highScore;
        //}


    }
}
