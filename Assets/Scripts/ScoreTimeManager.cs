using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTimeManager : MonoBehaviour
{
    public Text level;
    public Text score;
    public Text timer;
    public GameObject canvas;

    private bool isTiming;
    private bool timeUp;
    private float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("CurrentScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (isTiming)
        {
            timeLeft -= Time.deltaTime;
            timer.text = timeLeft.ToString("0");
            if (timeLeft <= 0)
            {
                timeUp = true;
                isTiming = false;
                timer.text = "0";
            }
        }
        if (SceneManager.GetActiveScene().name == "StartMenu" || SceneManager.GetActiveScene().name == "Credits")
        {
            canvas.SetActive(false);
        }
        else
        {
            canvas.SetActive(true);
            level.text = SceneManager.GetActiveScene().name.Substring(SceneManager.GetActiveScene().name.Length - 3);
        }

        score.text = PlayerPrefs.GetInt("CurrentScore").ToString();
    }

    public void AddScore(int scoreToAdd)
    {
        PlayerPrefs.SetInt("CurrentScore", PlayerPrefs.GetInt("CurrentScore") + scoreToAdd);
    }

    public int GetScore()
    {
        return PlayerPrefs.GetInt("CurrentScore");
    }

    public void SetScore(int score)
    {
        PlayerPrefs.SetInt("CurrentScore", score);
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("CurrentScore", 0);
    }

    public void StartTimer(float seconds)
    {
        if (isTiming)
        {
            StopTimer();
        }
        timeLeft = seconds;
        isTiming = true;
        timeUp = false;
    }

    public void StopTimer()
    {
        timeLeft = 0f;
        timeUp = true;
        isTiming = false;
        timer.text = "0";
    }

    public int GetTimeLeft()
    {
        if (timeUp)
        {
            return 0;
        }
        else
        {
            return Mathf.RoundToInt(timeLeft);
        }
    }
}