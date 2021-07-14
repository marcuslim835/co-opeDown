using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TrivialQuestionsStage4 : MonoBehaviour
{
    public Text question;
    public Text platformA;
    public Text platformB;
    public Text platformC;
    public Text sum;

    public Timer timer;

    public int totalNumberOfQuestions = 5;

    private int sumTotal = 0;

    private int count = 0;

    private bool isFineToAskAnotherQuestion;

    ArrayList arr = new ArrayList();

    int numberOfQuestionsImplemented = 8;
    private string[,] playerQuestions = new string[8, 4] {
        {"Player 1 is ready to open up", "Yes", "No", "Don't Know"},
        {"Player 1 just can't stop similing", "Yes", "No", "Secret"},
        {"Player 1 is", "Trying to \n be in a better place", "Hoping for \n more love", "Gonna achieve \n euphoria" },
        {"Player 2 is ready to open up", "Yes", "No", "Don't Know"},
        {"Player 2 just can't stop smiling", "Yes", "No", "Secret"},
        {"Player 2 is", "10/10", "5/10", "8/10" },
        {"Player 1 is", "10/10", "5/10", "8/10"  },
        {"Player 2 is", "Trying to \n be in a better place", "Hoping for \n more love", "Gonna achieve \n euphoria"}
    };

    // Start is called before the first frame update
    void Start()
    {
        Generate();
        InputPreferredAnswer();
        isFineToAskAnotherQuestion = true;
    }

    //Update is called once per frame
    void Update()
    {
        if (isFineToAskAnotherQuestion)
        {
            InputPreferredAnswer();
        }
    }


    public void InputPreferredAnswer()
    {

        if ((Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.LeftArrow)) ||
            (Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.DownArrow)) ||
            (Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.RightArrow))
            )
        {
            Debug.Log("hi");
            question.text = "CORRECT!";
            Debug.Log("Correct!");
            sumTotal += 1;
            sum.text = (sumTotal).ToString() + "/" + totalNumberOfQuestions.ToString();
            count++;
            timer.StopTimer();

            isFineToAskAnotherQuestion = false;

            Invoke("Generate", 2);//this will happen after 2 seconds
        }

        if ((Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.DownArrow)) ||
            (Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.RightArrow)) ||
            (Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.LeftArrow)) ||
            (Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.RightArrow)) ||
            (Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.LeftArrow)) ||
            (Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.DownArrow)) || timer.timeUp
            )
        {
            Debug.Log("gg");
            question.text = "WRONG!";
            count++;
            timer.StopTimer();

            isFineToAskAnotherQuestion = false;

            Invoke("Generate", 2);//this will happen after 2 seconds
        }

    }

    void Generate()
    {
        if (count >= totalNumberOfQuestions)
        {
            Invoke("NextLevel", 1f);
            FindObjectOfType<LevelLoader>().AllowTransit("Pass");
        }
        else
        {

            int questionNumber = Random.Range(0, numberOfQuestionsImplemented);
            if ((arr == null) || (!arr.Contains(questionNumber)))
            {
                question.text = playerQuestions[questionNumber, 0];
                platformA.text = playerQuestions[questionNumber, 1];
                platformB.text = playerQuestions[questionNumber, 2];
                platformC.text = playerQuestions[questionNumber, 3];
                arr.Add(questionNumber);

                isFineToAskAnotherQuestion = true;

                timer.StartTimer();
            }
            else
            {
                Generate();
            }
        }
    }

    void Wait()
    {

    }

    void NextLevel()
    {
        int scoreFromThisLevel = 0;

        for (int n = 0; n < sumTotal; n++)
        {
            scoreFromThisLevel += 20;
        }
        FindObjectOfType<ScoreTimeManager>().AddScore(scoreFromThisLevel);
        FindObjectOfType<NavigationOptions>().LoadNextLevel();
    }
}
