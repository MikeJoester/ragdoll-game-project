using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class LoadArea : MonoBehaviour
{
    [SerializeField]
    public string sceneName;

    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag == "Player") {
            SceneManager.LoadScene(sceneName);
            Console.WriteLine("collided");
        }
    }
}
