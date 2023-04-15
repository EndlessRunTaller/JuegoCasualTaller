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
    public float MaxScoreCount;

    public float pointsPerSecond;

    public bool scooreIncreasing;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreCount += pointsPerSecond * Time.deltaTime;
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        MaxScoreText.text = "High score: " + Mathf.Round(MaxScoreCount);
    }
}
