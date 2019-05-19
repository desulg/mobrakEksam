using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ghostScript : MonoBehaviour {
    int Time = 0;

    public GameObject target; //this is the player

    NavMeshAgent agent; //This is a reference for the ghost

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        if (target == null)
            target = GameObject.FindGameObjectWithTag("Player");

	}
	
	// Update is called once per frame
	void Update () {
        //this is for updating the target location
        agent.destination = target.transform.position;
        Vector3 Pos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Time += 1;
        Debug.Log(Time);
        if (Pos.y < 0) { onOutsideOfBounds(); }

    }

    public void onOutsideOfBounds(){
        SceneManager.LoadScene("menu");
    }

    //function to detect when the ghost gets the player
    public void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player")
            SceneManager.LoadScene("menu");
    }
}
