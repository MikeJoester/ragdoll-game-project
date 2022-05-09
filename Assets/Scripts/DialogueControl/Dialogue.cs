using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [Header("Dialogue")]
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public static float textSpeed = 0.09f;
    public static int CharPhase = 0;
    public GameObject DialogueScreen;

    [Header("Character")]
    public Image Character;
    public Image charBorder;
    public Sprite[] spriteArray;
    public int AppearIndex;

    private int index;

    void Start()
    {
        textComponent.text = string.Empty;
        charBorder.enabled = false;
        Character.enabled = false;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            if (textComponent.text == lines[index]) {
                if (CharPhase == AppearIndex) {
                    charBorder.enabled = true;
                    Character.enabled = true;
                }
    
                NextLine();

                Character.sprite = spriteArray[CharPhase - AppearIndex];
            }
            else {
                StopAllCoroutines();
                textComponent.text = lines[index];
                CharPhase += 1;
            }
        }
    }

    public void StartDialogue() {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine() {
        foreach (char c in lines[index].ToCharArray()) {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine() {
        if (index < lines.Length - 1) {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else {
            DialogueScreen.SetActive(false);
        }
    }
}
