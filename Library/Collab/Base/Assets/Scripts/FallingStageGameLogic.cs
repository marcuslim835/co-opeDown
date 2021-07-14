using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FallingStageGameLogic : MonoBehaviour
{
    public PlayerCollision p1;
    public PlayerCollision p2;

    public GameObject slowDropObject;
    public GameObject fastDropObject;
    public float chanceOfFast;
    public float spawnGap;

    private float nextSpawnTime = 0f;

    private int scoreToAdd;
    public Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        scoreToAdd = 0;
        Invoke("NextLevel", 30f);
        FindObjectOfType<ScoreTimeManager>().StartTimer(30f);
        if (PlayerPrefs.GetString("GameDifficulty") == "Easy")
        {
            chanceOfFast = 0.25f;
        }
        else if (PlayerPrefs.GetString("GameDifficulty") == "Normal")
        {
            chanceOfFast = 0.5f;
        }
        else
        {
            chanceOfFast = 0.75f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + spawnGap;
            if (Random.Range(0f, 1f) < chanceOfFast)
            {
                Instantiate(fastDropObject, new Vector2(Random.Range(-9f, 9f), 8), Quaternion.identity);
            }
            else
            {
                Instantiate(slowDropObject, new Vector2(Random.Range(-9f, 9f), 8), Quaternion.identity);
            }
            
        }
        scoreDisplay.text = scoreToAdd.ToString();
    }

    public void AddPoints(int points)
    {
        Debug.Log("Plus Point!");
        scoreToAdd += points;
    }

    void NextLevel()
    {
        FindObjectOfType<ScoreTimeManager>().AddScore(scoreToAdd * 5);
        FindObjectOfType<ScoreTimeManager>().StopTimer();
        FindObjectOfType<NavigationOptions>().LoadNextLevel();
    }
}
