using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI score;
    float thescore = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + thescore;
    }

     void ScoreUp()
    {
        thescore++;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Block")
        {
            ScoreUp();
        }
    }
}

