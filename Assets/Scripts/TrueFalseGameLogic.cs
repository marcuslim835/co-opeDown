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
    public int maxRandomNum;
    public int minRandomNum;

    private bool isComplete;

    private List<string> trueEasyQnBank = new List<string>() 
    { 
        "Singapore was invaded by the Japanese in the year 1942",
        "Cows sleep standing up",
        "Fish cannot blink",
        "Australia is both a country and a continent",
        "An olympic swimming pool is 50 meters long", //5
        "'www' in a website browser stands for the World Wide Web",
        "The duck-billed platypus is a mammal that lays eggs",
        "A spider has 8 legs",
        "China invented ice cream"

    };
    private List<string> trueNormalQnBank = new List<string>()
    {
        "Singapore is one of the commonwealth countries",
        "The middle name of Donald Duck is Fauntelroy",
        "The five rings on the Olympic flag are interlocking",
        "New Zealand has more sheep than people",
        "Russia borders both North Korea and Norway", //5
        "Gunpowder was invented in China",
        "A horse can be seen on the Porsche logo",
        "The Statue of Liberty was a gift from France",
        "Atoms are most tightly packed in solids"
    };
    private List<string> trueHardQnBank = new List<string>()
    {
        "The national animal of Scotland is the unicorn",
        "The Great Wall of China is longer than the distance between London and Beijing",
        "Cynophobia is the fear of dogs",
        "The first woman to win a Nobel Prize (in 1903) is Marie Curie",
        "Switzerland consumes the most chocolate per capita", //5
        "Havana is the capital of Cuba",
        "Canada has the most natural lakes in the world",
        "Venus is the hottest planet in the solar system",
        "In the state of Georgia, it is illegal to eat fried chicken with a fork"
    };
    private List<string> falseEasyQnBank = new List<string>()
    {
        "The first president of the United States is Joe Biden",
        "Thomas Edison discovered gravity",
        "Mount Kilimanjaro is the highest mountain in the world",
        "The capital of Singapore is Marina Bay",
        "Mount Everest is found in Europe", //5
        "Earth is the largest planet in the solar system",
        "COVID-19 does not affect kids",
        "Singapore has two time zones",
        "There are one thousand years in a century"

    };
    private List<string> falseNormalQnBank = new List<string>()
    {
        "'A' is the most common letter used in the English language",
        "An octopus has five hearts",
        "A heptagon has eight sides",
        "Switzerland is part of the European Union", //5
        "Mount Everest is a volcano",
        "Meat is consumed by herbivore animals",
        "Leonardo da Vinci is a French painter",
        "Camels can store water in their humps"
    };
    private List<string> falseHardQnBank = new List<string>()
    {
        "The capital of Libya is Benghazi",
        "A woman has walked on the moon",
        "The skin of polar bears is white",
        "Nepal is the only country in the world which does not have a rectangular flag",
        "Gouda cheese originates from Italy", //5
        "The Berlin Wall came down in 1979",
        "Sydney is the capital of Australia",
        "An object at rest on Earth does not have inertia",
        "Vatican City is the smallest city in the world"
    };

    // Start is called before the first frame update
    void Start()
    {
        isComplete = false;
        //0 for math, 1 for statement
        int questionType = Random.Range(0, 2);
        //0 for false, 1 for true
        int answerTruthfulness = Random.Range(0, 2);

        if (questionType == 0)
        {
            int numOne = Random.Range(minRandomNum, maxRandomNum);
            int numTwo = Random.Range(minRandomNum, maxRandomNum);
            int wrongNumOffset = Random.Range(1, 4);
            if (answerTruthfulness == 0)
            {
                if (PlayerPrefs.GetString("GameDifficulty") == "Easy")
                {
                    question.text = numOne.ToString() + " + " + numTwo.ToString()
                    + " = " + (numOne + numTwo + wrongNumOffset).ToString();
                }
                else if (PlayerPrefs.GetString("GameDifficulty") == "Normal")
                {
                    question.text = numOne.ToString() + " x " + numTwo.ToString()
                    + " = " + (numOne * numTwo + wrongNumOffset * 2).ToString();
                }
                else
                {
                    question.text = numOne.ToString() + "\u00B2 x " + numTwo.ToString()
                    + " = " + (numOne * numOne * numTwo + wrongNumOffset * 2).ToString();
                }
                falsePlatform.tag = "CorrectAnswerA";
                truePlatform.tag = "CorrectAnswerB";
            }
            else
            {
                if (PlayerPrefs.GetString("GameDifficulty") == "Easy")
                {
                    question.text = numOne.ToString() + " + " + numTwo.ToString()
                    + " = " + (numOne + numTwo).ToString();
                }
                else if (PlayerPrefs.GetString("GameDifficulty") == "Normal")
                {
                    question.text = numOne.ToString() + " x " + numTwo.ToString()
                    + " = " + (numOne * numTwo).ToString();
                }
                else
                {
                    question.text = numOne.ToString() + "\u00B2 x " + numTwo.ToString()
                    + " = " + (numOne * numOne * numTwo).ToString();
                }
                truePlatform.tag = "CorrectAnswerA";
                falsePlatform.tag = "CorrectAnswerB";
            }
        }
        //statement questions
        else
        {
            if (answerTruthfulness == 0)
            {
                if (PlayerPrefs.GetString("GameDifficulty") == "Easy")
                {
                    question.text = falseEasyQnBank[Random.Range(0, falseEasyQnBank.Count)];
                }
                else if (PlayerPrefs.GetString("GameDifficulty") == "Normal")
                {
                    question.text = falseNormalQnBank[Random.Range(0, falseNormalQnBank.Count)];
                }
                else
                {
                    question.text = falseHardQnBank[Random.Range(0, falseHardQnBank.Count)];
                }
                falsePlatform.tag = "CorrectAnswerA";
                truePlatform.tag = "CorrectAnswerB";
            }
            else
            {
                if (PlayerPrefs.GetString("GameDifficulty") == "Easy")
                {
                    question.text = trueEasyQnBank[Random.Range(0, trueEasyQnBank.Count)];
                }
                else if (PlayerPrefs.GetString("GameDifficulty") == "Normal")
                {
                    question.text = trueNormalQnBank[Random.Range(0, trueNormalQnBank.Count)];
                }
                else
                {
                    question.text = trueHardQnBank[Random.Range(0, trueHardQnBank.Count)];
                }
                
                truePlatform.tag = "CorrectAnswerA";
                falsePlatform.tag = "CorrectAnswerB";
            }
        }
        FindObjectOfType<ScoreTimeManager>().StartTimer(60f);
    }

    // Update is called once per frame
    void Update()
    {
        if (p1.isCorrectA && p2.isCorrectA)
        {
            if (isComplete == false)
            {
                isComplete = true;
                //question.text = "Answer is Correct!";
                Invoke("NextLevel", 1f);
                FindObjectOfType<LevelLoader>().AllowTransit("Pass");
            }
        }
        if (FindObjectOfType<ScoreTimeManager>().GetTimeLeft() <= 0 || p1.isCorrectB && p2.isCorrectB)
        {
            if (isComplete == false)
            {
                //question.text = "Answer is Incorrect!";
                Invoke("NextLevel", 1f);
                FindObjectOfType<LevelLoader>().AllowTransit("Fail");
            }
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
}
