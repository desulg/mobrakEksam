using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    //function click for the button
    void Start()
    {
        //var m_Score = PlayerPrefsX.GetIntArray("Scores");
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
