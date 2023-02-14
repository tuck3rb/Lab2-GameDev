using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireplace : MonoBehaviour {

    [SerializeField] private AudioSource fire_noise;

    // Start is called before the first frame update
    void Start()
    {
        fire_noise = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            // GameManager.Instance.ClickFireplace(scene);
            print("clicked!");
            StartCoroutine("FireSound");
        }
    }

    IEnumerator FireSound()
    {
        fire_noise.Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        
    }
}
