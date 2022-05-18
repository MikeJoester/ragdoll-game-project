using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class LoadArea : MonoBehaviour
{
    [SerializeField]
    public string sceneName;
    public string exitPoint;
    private PlayerMovements player;

    public Animator SceneTransition;

    void Start() {
        player = FindObjectOfType<PlayerMovements>();
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag == "Player") {
            player.startPoint = exitPoint;

            StartCoroutine(LoadLevel());
        }
    }

    IEnumerator LoadLevel() {
        SceneTransition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(sceneName);
    }
}
