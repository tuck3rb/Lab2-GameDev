using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Inspired by https://github.com/mgoadric/csci370/blob/master/2023/Diggers/Assets/Scripts/GameManager.cs
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;

    public GameObject endBox;
    public TextMeshProUGUI endText;

    public GameObject eventSystem;
    public GameObject canvas;


    public void DialogShow(string text) {
        dialogBox.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(TypeText(text));
    }

    public void DialogHide() {
        dialogBox.SetActive(false);
    }

    IEnumerator TypeText(string text) {
        dialogText.text = "";
        foreach (char c in text.ToCharArray()) {
            dialogText.text += c;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void EndShow(string text) {
        endBox.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(TypeEndText(text));
    }

    public void EndHide() {
        endBox.SetActive(false);
    }

    IEnumerator TypeEndText(string text) {
        endText.text = "";
        foreach (char c in text.ToCharArray()) {
            endText.text += c;
            yield return new WaitForSeconds(0.02f);
        }
    }

    void Awake() {
        print("TEST");
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(eventSystem);
            DontDestroyOnLoad(canvas);
        }
        else {
            print("DESTROY TEST");
            Destroy(gameObject);
        }
    }


    public void ClickFireplace(string scene) {
        // maybe need this?
    }


    // Update is called once per frame
    void Update() {

    }

    
}
