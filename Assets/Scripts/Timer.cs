using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime;
    public Text countDownText;
    public bool isRunning = false;
    public bool timeUp = false;

    // Start is called before the first frame update
    void Start()
    {
        
        // Difficulty levels
        if (PlayerPrefs.GetString("GameDifficulty") == "Easy")
        {
            startingTime = 15f;

            Debug.Log("15 seconds");
        }
        else if (PlayerPrefs.GetString("GameDifficulty") == "Normal")
        {
            startingTime = 10f;

            Debug.Log("10 seconds");
        }
        else
        {
            startingTime = 15f;

            Debug.Log("5 seconds");
        }

        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            currentTime -= 1 * Time.deltaTime;

            if (currentTime > startingTime)
            {
                countDownText.text = "";
            }
            else if (currentTime > 0)
            {
                countDownText.text = currentTime.ToString("0");
            } else 
            
            {
                timeUp = true;
                isRunning = false;
            }
        } else
        {
            timeUp = false;
            countDownText.text = "";
        }
    }

    public void StartTimer()
    {
        currentTime = startingTime;
        timeUp = false;
        isRunning = true;
    }

    public void StopTimer()
    {
        currentTime = startingTime;
        isRunning = false;
    }
}
