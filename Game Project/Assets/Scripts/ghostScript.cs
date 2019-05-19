using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ghostScript : MonoBehaviour {
    int Time;

    public GameObject target; //this is the player

    NavMeshAgent agent; //This is a reference for the ghost

    // Use this for initialization
    void Start() {
        Time = 0;
        agent = GetComponent<NavMeshAgent>();
        if (target == null)
            target = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update() {
        //this is for updating the target location
        agent.destination = target.transform.position;
        Vector3 Pos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Time += 1;
        //Debug.Log(Time);
        if (Pos.y < 0) { onOutsideOfBounds(); }

    }

    public void onOutsideOfBounds() {

        int prevScore = PlayerPrefs.GetInt("HighScore", 0);
        Time = Time + PlayerPrefs.GetInt("LastLevelScore", 0);
        Debug.Log(Time + "This is the current score" + Time + "High scoreis: " + prevScore);
        PlayerPrefs.SetInt("LastLevelScore", 0);
        if (prevScore < Time) {
        PlayerPrefs.SetInt("HighScore", Time);
        }
        SceneManager.LoadScene("menu");
    }

    public int getScore() {
        return (Time);
    }

    //function to detect when the ghost gets the player
    public void OnCollisionEnter(Collision collision)
    {
        int prevScore = PlayerPrefs.GetInt("HighScore", 0);
        Time = Time + PlayerPrefs.GetInt("LastLevelScore", 0);
        PlayerPrefs.SetInt("LastLevelScore", 0);
        Debug.Log(Time + "This is the current score" + Time + "High scoreis: " + prevScore);
        if (prevScore < Time)
        {
            PlayerPrefs.SetInt("HighScore", Time);
        }
        if (collision.gameObject.tag == "Player")
            SceneManager.LoadScene("menu");
    }
}
