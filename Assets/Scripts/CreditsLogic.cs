using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsLogic : MonoBehaviour
{
    public Text scoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        int score = FindObjectOfType<ScoreTimeManager>().GetScore();
        string scoretext = score.ToString();
        //scoreDisplay.text = FindObjectOfType<ScoreTimeManager>().GetScore().ToString();
        scoreDisplay.text = scoretext;

        if (PlayerPrefs.GetString("GameMode") == "Classic")
        {
            if (PlayerPrefs.GetString("GameDifficulty") == "Easy")
            {
                if (score > PlayerPrefs.GetInt("HighScoreEasyClassic", 0))
                {
                    PlayerPrefs.SetInt("HighScoreEasyClassic", score);
                }
            }
            else if (PlayerPrefs.GetString("GameDifficulty") == "Normal")
            {
                if (score > PlayerPrefs.GetInt("HighScoreNormalClassic", 0))
                {
                    PlayerPrefs.SetInt("HighScoreNormalClassic", score);
                }
            }
            else
            {
                if (score > PlayerPrefs.GetInt("HighScoreHardClassic", 0))
                {
                    PlayerPrefs.SetInt("HighScoreHardClassic", score);
                }
            }
        } else
        {
            if (PlayerPrefs.GetString("GameDifficulty") == "Easy")
            {
                if (score > PlayerPrefs.GetInt("HighScoreEasyEndless", 0))
                {
                    PlayerPrefs.SetInt("HighScoreEasyEndless", score);
                }
            }
            else if (PlayerPrefs.GetString("GameDifficulty") == "Normal")
            {
                if (score > PlayerPrefs.GetInt("HighScoreNormalEndless", 0))
                {
                    PlayerPrefs.SetInt("HighScoreNormalEndless", score);
                }
            }
            else
            {
                if (score > PlayerPrefs.GetInt("HighScoreHardEndless", 0))
                {
                    PlayerPrefs.SetInt("HighScoreHardEndless", score);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
