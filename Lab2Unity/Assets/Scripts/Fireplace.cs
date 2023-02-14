using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireplace : MonoBehaviour {

    [SerializeField] private AudioSource fire_noise;
    public string scene;
    public GameObject flames;

    // Start is called before the first frame update
    void Start()
    {
        fire_noise = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetMouseButtonDown(0)) {
        //     if (LookForGameObject(out RaycastHit hit)) {
        //         StartCoroutine("FireSound");
        //         Instantiate(flames);
        //         GameManager.Instance.ClickFireplace(scene);
        //     }
        // }
    }

    void OnMouseDown() {
        StartCoroutine("FireSound");
        Instantiate(flames);
        GameManager.Instance.ClickFireplace(scene);
    }

    IEnumerator FireSound()
    {
        fire_noise.Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        
    }

    // private bool LookForGameObject(out RaycastHit hit) {
    //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //     return Physics.Raycast(ray, out hit);
    // }

}
