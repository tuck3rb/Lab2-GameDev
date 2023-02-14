using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance {get; private set;}

    public TextMeshProUGUI scoreText;

    [SerializeField] private AudioSource noise;

    int score = 0;

    private void Awake() {
        instance = this;
    }

    // Start is called before the first frame update
    public void Start()
    {
        scoreText.text = score.ToString() + " POINTS";
        noise = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint() {
        score += 10;
        scoreText.text = score.ToString() + " POINTS";
        StartCoroutine("Sound");
    }

    IEnumerator Sound()
    {
        noise.Play();
        Debug.Log("Playing Crash Now I Hope??");
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        
    }

}
