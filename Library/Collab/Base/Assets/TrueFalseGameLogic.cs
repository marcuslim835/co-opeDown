using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrueFalseGameLogic : MonoBehaviour
{
    public PlayerCollision p1;
    public PlayerCollision p2;

    public Text question;
    public Text truePlatform;
    public Text falsePlatform;

    private bool isComplete;

    private List<string> trueQnBank = new List<string>() 
    { 
        "The national animal of Scotland is the unicorn", 
        "The Great Wall of China is longer than the distance between London and Beijing" 
    };
    private List<string> falseQnBank = new List<string>() 
    {
        "'A' is the most common letter used in the English language",
        "Thomas Edison discovered gravity"
    };
    
    // Start is called before the first frame update
    void Start()
    {
        isComplete = false;
        int questionType = Random.Range(0, 2);
        int answerTruthfulness = Random.Range(0, 2);

        if (questionType == 0)
        {
            int numOne = Random.Range(5, 20);
            int numTwo = Random.Range(5, 20);
            int wrongNumOffset = Random.Range(1, 4);
            if (answerTruthfulness == 0)
            {
                question.text = numOne.ToString() + " + " + numTwo.ToString()
                    + " = " + (numOne + numTwo + wrongNumOffset).ToString();
                falsePlatform.tag = "CorrectAnswerA";
            }
            else
            {
                question.text = numOne.ToString() + " + " + numTwo.ToString()
                    + " = " + (numOne + numTwo).ToString();
                truePlatform.tag = "CorrectAnswerA";
            }
        }
        else
        {
            if (answerTruthfulness == 0)
            {
                question.text = trueQnBank[Random.Range(0, trueQnBank.Count)];
                falsePlatform.tag = "CorrectAnswerA";
            }
            else
            {
                question.text = falseQnBank[Random.Range(0, falseQnBank.Count)];
                truePlatform.tag = "CorrectAnswerA";
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (p1.isCorrectA && p2.isCorrectA)
        {
            if (isComplete == false)
            {
                isComplete = true;
                Invoke("NextLevel", 1f);
            }
        }
    }

    void NextLevel()
    {
        FindObjectOfType<ScoreTimeManager>().AddScore(100);
        FindObjectOfType<NavigationOptions>().LoadNextLevel();
    }
}
