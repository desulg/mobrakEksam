using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevelScript : MonoBehaviour {
    int Score;
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            int lastScore = PlayerPrefs.GetInt("LastLevelScore", 0);
            Debug.Log("Last Level Score: "+ lastScore);
            Score = GameObject.Find("Ghost").GetComponent<ghostScript>().getScore();
            Debug.Log("This level Score: " + Score);
            Score = Score + lastScore;
            PlayerPrefs.SetInt("LastLevelScore", Score);
            Debug.Log(Score);
            // If()
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //load the next level
            }
            
        }
    }
}
