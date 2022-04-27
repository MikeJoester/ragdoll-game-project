using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    private bool triggerEntered = false;
    public GameObject DialogueScreen;

    void Start() {
        
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.E) && triggerEntered == true) {
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
