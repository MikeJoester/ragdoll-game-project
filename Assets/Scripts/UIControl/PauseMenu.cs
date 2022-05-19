using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    private SFXManager sfxMan;

    private static bool menuExists;

    void Start() {
        sfxMan = FindObjectOfType<SFXManager>();
        // if (!menuExists) {
        //     cameraExists = true;
        //     DontDestroyOnLoad(transform.gameObject);
        // }
        // else {
        //     Destroy(gameObject);
        // }
    }
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (GameIsPaused) {
                Resume();
            }
            else {
                Pause();
            }
        }
    }

    public void Resume() {
        sfxMan.playerInteract.Play();
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause() {
        sfxMan.openMenu.Play();
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
