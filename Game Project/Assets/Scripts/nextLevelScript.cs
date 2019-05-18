using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevelScript : MonoBehaviour {

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //load the next level
    }
}
