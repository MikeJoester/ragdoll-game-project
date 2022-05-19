using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    private bool triggerEntered = false;
    public GameObject DialogueScreen;
    private SFXManager sfxMan;

    void Start() {
        sfxMan = FindObjectOfType<SFXManager>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.E) && triggerEntered == true) {
            sfxMan.playerInteract.Play();
            DialogueScreen.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.tag == "Player") {
            triggerEntered = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider) {
        triggerEntered = false;
    }
}
