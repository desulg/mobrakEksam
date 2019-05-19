using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public Text highscoreText;

    //function click for the button
    void Start()
    {
        highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("HighScore",0);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnSceneLoaded(Scene aScene, LoadSceneMode aMode)
    {
        Debug.Log("OnSceneLoaded: ");
    }
    public void button_click()
    {
        SceneManager.LoadScene(1);
    }
}
