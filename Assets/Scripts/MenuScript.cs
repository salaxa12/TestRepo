using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuScript : MonoBehaviour
{
    public TMP_InputField nameValue;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene("main");
        PlayerPrefs.SetString("name", nameValue.text);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
