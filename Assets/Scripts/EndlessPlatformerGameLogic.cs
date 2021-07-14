using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndlessPlatformerGameLogic : MonoBehaviour
{
    public PlayerCollision p1;
    public PlayerCollision p2;

    public List<Text> textList;
    public Text sum;
    public Text instructions;
    public static int maxRandomNum = 20;
    public static int minRandomNumA = 2;
    public static int minRandomNumB = 10;

    private int platformA;
    private int platformB;
    private int ansA;
    private int ansB;
    private List<int> intList = new List<int>();
    private bool isComplete;

    void Start()
    {
        isComplete = false;
        //randomize which platform to contain correct answer
        platformA = Random.Range(0, 5);
        platformB = Random.Range(0, 5);
        while (platformA == platformB)
        {
            platformB = Random.Range(0, 5);
        }
        //randomize correct answer choices
        ansA = Random.Range(minRandomNumA, maxRandomNum);
        ansB = Random.Range(minRandomNumB, maxRandomNum);
        while (ansA == ansB)
        {
            ansB = Random.Range(minRandomNumB, maxRandomNum);
        }
        textList[platformA].text = ansA.ToString();
        textList[platformB].text = ansB.ToString();
        textList[platformA].tag = "CorrectAnswerA";
        textList[platformB].tag = "CorrectAnswerB";
        intList.Add(ansA);
        intList.Add(ansB);
        intList.Add(ansA + ansB);

        //easy difficulty generation
        if (PlayerPrefs.GetString("GameDifficulty") == "Easy")
        {
            instructions.text = "Stand on 2 platforms \nthat sum up to";
            sum.text = (ansA + ansB).ToString();
            intList.Add(ansA + ansB);
            //randomize wrong answers that cannot possibly be combined to give correct sum
            foreach (Text t in textList)
            {
                if (t.text != 0.ToString())
                {
                    continue;
                }
                int numToAdd = Random.Range(minRandomNumA, maxRandomNum);
                while (intList.Contains(numToAdd))
                {
                    numToAdd = Random.Range(minRandomNumA, maxRandomNum);
                }
                intList.Add(numToAdd);
                intList.Add(ansA + ansB - numToAdd);
                t.text = numToAdd.ToString();
            }
        }
        //normal difficulty generation
        else if (PlayerPrefs.GetString("GameDifficulty") == "Normal")
        {
            instructions.text = "Stand on 2 platforms \nthat multiplies together to give";
            sum.text = (ansA * ansB).ToString();
            intList.Add(ansA * ansB);
            //randomize wrong answers that cannot possibly be combined to give correct product
            foreach (Text t in textList)
            {
                if (t.text != 0.ToString())
                {
                    continue;
                }
                int numToAdd = Random.Range(minRandomNumA, maxRandomNum);
                while (intList.Contains(numToAdd) || (ansA * ansB) % numToAdd == 0)
                {
                    numToAdd = Random.Range(minRandomNumA, maxRandomNum);
                }
                intList.Add(numToAdd);
                t.text = numToAdd.ToString();
            }
        }
        //hard difficulty generation
        else
        {
            instructions.text = "Stand on 2 platforms \nthat solves the following polynomial";
            sum.text = "X\u00B2 + " + (0 - ansA - ansB).ToString() + "X + " + (ansA * ansB).ToString() + " = 0";
            //randomize wrong answers that cannot possibly be combined to give correct sum
            foreach (Text t in textList)
            {
                if (t.text != 0.ToString())
                {
                    continue;
                }
                int numToAdd = Random.Range(minRandomNumA, maxRandomNum);
                while (intList.Contains(numToAdd))
                {
                    numToAdd = Random.Range(minRandomNumA, maxRandomNum);
                }
                intList.Add(numToAdd);
                t.text = numToAdd.ToString();
            }
        }
        FindObjectOfType<ScoreTimeManager>().StartTimer(60f);
    }

    void Update()
    {
        if ((p1.isCorrectA && p2.isCorrectB) || (p2.isCorrectA && p1.isCorrectB))
        {
            if (isComplete == false)
            {
                isComplete = true;
                //sum.text = "Stage Cleared!";
                maxRandomNum += 5;
                minRandomNumA += 5;
                minRandomNumB += 5;
                Invoke("NextLevel", 1f);
                FindObjectOfType<LevelLoader>().AllowTransit("Pass");
            }
        }
        if (FindObjectOfType<ScoreTimeManager>().GetTimeLeft() <= 0 && isComplete == false)
        {
            //sum.text = "Game Over!";
            maxRandomNum = 20;
            minRandomNumA = 2;
            minRandomNumB = 10;
            Invoke("EndGame", 1f);
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
        intList.Clear();
        FindObjectOfType<NavigationOptions>().LoadThisLevel("SceneE-E");
    }

    void EndGame()
    {
        FindObjectOfType<ScoreTimeManager>().StopTimer();
        intList.Clear();
        FindObjectOfType<NavigationOptions>().LoadThisLevel("Credits");
    }
}
