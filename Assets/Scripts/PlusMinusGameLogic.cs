using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlusMinusGameLogic : MonoBehaviour
{
    public Text targetSum;
    public Text currentSum;

    private bool isComplete;

    void Start()
    {
        isComplete = false;
        FindObjectOfType<ScoreTimeManager>().StartTimer(60f);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (int.Parse(currentSum.text) == int.Parse(targetSum.text))
        {
            if (isComplete == false)
            {
                isComplete = true;
                Invoke("NextLevel", 1f);
                FindObjectOfType<LevelLoader>().AllowTransit("Pass");
            }
        }
        if (FindObjectOfType<ScoreTimeManager>().GetTimeLeft() <= 0 && isComplete == false)
        {
            Invoke("NextLevel", 1f);
            FindObjectOfType<LevelLoader>().AllowTransit("Fail");
        }
    }

    void NextLevel()
    {
        if (isComplete)
        {
            FindObjectOfType<ScoreTimeManager>().AddScore(100 + FindObjectOfType<ScoreTimeManager>().GetTimeLeft());
        }
        FindObjectOfType<ScoreTimeManager>().StopTimer();
        FindObjectOfType<NavigationOptions>().LoadNextLevel();
    }

    public void ResetSum()
    {
        currentSum.text = "0";
    }

    public void ChangeSum(int numToAdd)
    {
        currentSum.text = (int.Parse(currentSum.text) + numToAdd).ToString();
    }

    public void MultiplySum(int multiplier)
    {
        currentSum.text = (int.Parse(currentSum.text) * multiplier).ToString();
    }

    public void ModifyTarget(int targetValue)
    {
        targetSum.text = (int.Parse(targetSum.text) + targetValue).ToString();
    }

    public void MultiplyTarget(int multiplier)
    {
        targetSum.text = (int.Parse(targetSum.text) * multiplier).ToString();
    }
}
