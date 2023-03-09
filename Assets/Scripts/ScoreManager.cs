using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    int score = 0;
    int highScore = 0;
    // Start is called before the first frame update
   private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0);
        scoreText.text = score.ToString() +  " POINTS";
        highScoreText.text = "HIGHSCORE: " + highScore.ToString(); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddPoint(int point)
    {
        score = score + point;
        scoreText.text = score.ToString() + " POINTS";
        if (highScore < score)
        {
            PlayerPrefs.SetInt("highScore", score);
        }
    }
}
