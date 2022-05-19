using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource playerGrab;
    public AudioSource playerEnter;
    
    private static bool sfxExists;

    void Start() {
        if (!sfxExists) {
            sfxExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }
}
