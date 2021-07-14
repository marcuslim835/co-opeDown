using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{

    public PlayerCollision p1;
    public PlayerCollision p2;

    public List<Text> textList;
    public Text sum;
    public int platformA;
    public int platformB;
    public int ansA;
    public int ansB;
    private List<int> intList = new List<int>();

    void Start()
    {
        //randomize which platform to contain correct answer
        platformA = Random.Range(0, 5);
        platformB = Random.Range(0, 5);
        while (platformA == platformB)
        {
            platformB = Random.Range(0, 5);
        }
        //randomize correct answer choices
        ansA = Random.Range(1, 20);
        ansB = Random.Range(1, 20);
        while (ansA == ansB)
        {
            ansB = Random.Range(1, 20);
        }
        sum.text = (ansA + ansB).ToString();
        textList[platformA].text = ansA.ToString();
        textList[platformB].text = ansB.ToString();
        textList[platformA].tag = "CorrectAnswer";
        textList[platformB].tag = "CorrectAnswer";
        intList.Add(ansA);
        intList.Add(ansB);
        //randomize wrong answers that cannot possibly be combined to give correct sum
        foreach (Text t in textList)
        {
            if (t.text != 0.ToString())
            {
                continue;
            }
            int numToAdd = Random.Range(1, 20);
            while (intList.Contains(numToAdd))
            {
                numToAdd = Random.Range(1, 20);
            }
            intList.Add(numToAdd);
            intList.Add(ansA + ansB - numToAdd);
            t.text = numToAdd.ToString();
        }
    }

    void Update()
    {
        if (p1.isCorrect && p2.isCorrect)
        {
            //Debug.Log("COMPLETE!");
            Invoke("NextLevel", 1f);
        }
    }

    void NextLevel()
    {
        intList.Clear();
        FindObjectOfType<NavigationOptions>().LoadNextLevel();
    }
}
