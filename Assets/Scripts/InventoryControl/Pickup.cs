using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
   private Inventory inventory;

   private void Start() {
       inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
   }

    void OnTriggerEnter2D(Collider2D collider) {
        
    }
}
