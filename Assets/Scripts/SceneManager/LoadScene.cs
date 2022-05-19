using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public AudioSource press;
    private Animator SceneTransition;

    void Start() {
        
    }

    public void StartButton() {
        press.Play();
        StartCoroutine(LevelTransition());
    }

    public void LoadButton() {
        press.Play();
        StartCoroutine(GameContinue());
    }

    public void ExitButton() {
        Application.Quit();
    }

    IEnumerator LevelTransition() {
        SceneTransition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("StartDialogue");
    }

    IEnumerator GameContinue() {
        SceneTransition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Map1");
    }
}
