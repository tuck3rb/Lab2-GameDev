using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trash : MonoBehaviour {

    public string text;

    private bool pickUpAllowed;

    public GameObject Explosion;

    public void OnTriggerEnter2D(Collider2D collider2D) {
        print("Entered..");
        if (collider2D.gameObject.CompareTag("Player")) {
            GameManager.Instance.DialogShow(text);
            pickUpAllowed = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collider2D) {
        if (collider2D.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.DialogHide();
            pickUpAllowed = false;
        }
    }

    void Start() {

    }

    void Update() {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }

    private void PickUp() {
        Instantiate(Explosion, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
        ScoreManager.instance.AddPoint();
    }


}
