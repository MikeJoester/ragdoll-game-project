using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
   private Inventory inventory;
   private SFXManager sfxMan;
   public Sprite itemButton;
   private static bool triggerEntered = false;

   private void Start() {
       inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
       sfxMan = FindObjectOfType<SFXManager>();
   }

   private void Update() {
       if (Input.GetKeyDown(KeyCode.E) && triggerEntered) {
            Debug.Log("Touched");
            for (int i = 0; i < inventory.slots.Length; i++) {
                if (inventory.isFull[i] == false) {
                    inventory.isFull[i] = true;
                    sfxMan.playerGrab.Play();
                    inventory.slots[i].sprite = itemButton;
                    //Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
   }

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.CompareTag("Player")) {
            triggerEntered = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider) {
        triggerEntered = false;
    }
}
