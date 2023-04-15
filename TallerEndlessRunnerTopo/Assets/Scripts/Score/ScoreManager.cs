using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI MaxScoreText;

    public float scoreCount;

    public float pointsPerSecond;

    public bool scooreIncreasing;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scooreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }
        

        if(scoreCount > GameController.current.MaxScore)
        {
            GameController.current.MaxScore = scoreCount;
        }

        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        MaxScoreText.text = "High score: " + Mathf.Round(GameController.current.MaxScore);


    }
}
