using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlatformGameLogicBoss : MonoBehaviour
{
    public PlayerCollision p1;
    public PlayerCollision p2;

    public Text sum;
    public static int scoreValue;
    public bool isComplete;

    public bool onePlayerDied;
    public bool twoPlayersDied;

    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        isComplete = false;
        FindObjectOfType<ScoreTimeManager>().StartTimer(60f);
        onePlayerDied = false;
        twoPlayersDied = false;

        //// Difficulty levels
        //if (PlayerPrefs.GetString("GameDifficulty") == "Easy")
        //{
        //    FindObjectOfType<EnemyAI>().speed = 350;
        //}
        //else if (PlayerPrefs.GetString("GameDifficulty") == "Normal")
        //{
        //    FindObjectOfType<EnemyAI>().speed = 400;
        //}
        //else
        //{
        //    FindObjectOfType<EnemyAI>().speed = 450;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //if (twoPlayersDied)
        //{
        //    sum.text = "Both Players Died :(";
        //    Invoke("NextLevel", 1f);
        //    FindObjectOfType<LevelLoader>().AllowTransit("Fail");
        //} else
        //{
        //    sum.text = scoreValue.ToString();
        //}

        if (FindObjectOfType<ScoreTimeManager>().GetTimeLeft() <= 0)
        {
            if (isComplete == false)
            {
                sum.text = "Stage Cleared!";
                isComplete = true;
                Invoke("NextLevel", 1f);
                FindObjectOfType<LevelLoader>().AllowTransit("Pass");
            }
        } else if (twoPlayersDied)
        {
            //sum.text = "Both Players Died :(";
            Invoke("NextLevel", 1f);
            FindObjectOfType<LevelLoader>().AllowTransit("Fail");
        }
        else
        {
            sum.text = scoreValue.ToString();
        }
    }

    public void NextLevel()
    {
        if (isComplete)
        {
            FindObjectOfType<ScoreTimeManager>().AddScore(100 + scoreValue * 5);
        }
        FindObjectOfType<ScoreTimeManager>().StopTimer();
        FindObjectOfType<NavigationOptions>().LoadNextLevel();
    }

    public void KillPlayer()
    {
        if (!onePlayerDied)
        {
            onePlayerDied = true;
        } else
        {
            twoPlayersDied = true;
        }
    }
}
