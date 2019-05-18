using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ghostScript : MonoBehaviour {

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

	}
    //function to detect when the ghost gets the player
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            SceneManager.LoadScene("menu");
    }
}
