using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
    public TMPro.TextMeshProUGUI gameOverText;
    public TMPro.TextMeshProUGUI startText;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hit" && collision.gameObject.tag != "finish")
        {
            score++;
            Debug.Log("You have bumped this many times: " + score);
        }
        if(collision.gameObject.tag == "Finish")
        {
            gameOverText.enabled = true;
            Debug.Log("You reached the finish line");
        }
    }
    void Start()
    {
        gameOverText.enabled = false;
        startText.enabled = true;
    }

    public int getScore()
    {
        return score;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > 3)
        {
            startText.enabled = false;
        }
    }
}
