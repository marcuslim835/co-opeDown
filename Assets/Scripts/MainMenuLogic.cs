using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuLogic : MonoBehaviour
{
    public GameObject canvas;
    public Toggle classicMode;
    public Toggle endlessMode;
    public Toggle easyDiff;
    public Toggle normalDiff;
    public Toggle hardDiff;

    public Text highScoreEasyClassic;
    public Text highScoreNormalClassic;
    public Text highScoreHardClassic;
    public Text highScoreEasyEndless;
    public Text highScoreNormalEndless;
    public Text highScoreHardEndless;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<ScoreTimeManager>().ResetScore();
        canvas.SetActive(false);
        if (PlayerPrefs.HasKey("GameMode"))
        {
            if (PlayerPrefs.GetString("GameMode") == "Classic")
            {
                classicMode.isOn = true;
                endlessMode.isOn = false;
            }
            else
            {
                classicMode.isOn = false;
                endlessMode.isOn = true;
            }
        }
        else
        {
            classicMode.isOn = true;
            endlessMode.isOn = false;
        }

        if (PlayerPrefs.HasKey("GameDifficulty"))
        {
            if (PlayerPrefs.GetString("GameDifficulty") == "Easy")
            {
                easyDiff.isOn = true;
                normalDiff.isOn = false;
                hardDiff.isOn = false;
            }
            else if (PlayerPrefs.GetString("GameDifficulty") == "Normal")
            {
                easyDiff.isOn = false;
                normalDiff.isOn = true;
                hardDiff.isOn = false;
            }
            else
            {
                easyDiff.isOn = false;
                normalDiff.isOn = false;
                hardDiff.isOn = true;
            }
        }
        else
        {
            easyDiff.isOn = false;
            normalDiff.isOn = true;
            hardDiff.isOn = false;
        }

        highScoreEasyClassic.text = PlayerPrefs.GetInt("HighScoreEasyClassic", 0).ToString();
        highScoreNormalClassic.text = PlayerPrefs.GetInt("HighScoreNormalClassic", 0).ToString();
        highScoreHardClassic.text = PlayerPrefs.GetInt("HighScoreHardClassic", 0).ToString();
        highScoreEasyEndless.text = PlayerPrefs.GetInt("HighScoreEasyEndless", 0).ToString();
        highScoreNormalEndless.text = PlayerPrefs.GetInt("HighScoreNormalEndless", 0).ToString();
        highScoreHardEndless.text = PlayerPrefs.GetInt("HighScoreHardEndless", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenGameSetup()
    {
        canvas.SetActive(true);
    }

    public void CloseGameSetup()
    {
        canvas.SetActive(false);
    }

    public void StartGame()
    {
        //remember difficulty settings
        if (easyDiff.isOn == true)
        {
            PlayerPrefs.SetString("GameDifficulty", "Easy");
        }
        else if (normalDiff.isOn == true)
        {
            PlayerPrefs.SetString("GameDifficulty", "Normal");
        }
        else
        {
            PlayerPrefs.SetString("GameDifficulty", "Hard");
        }
        
        //remember mode settings
        if (classicMode.isOn == true)
        {
            //Load Classic Mode
            PlayerPrefs.SetString("GameMode", "Classic");
            FindObjectOfType<NavigationOptions>().LoadNextLevel();
        }
        else
        {
            //Load Endless Mode
            PlayerPrefs.SetString("GameMode", "Endless");
            FindObjectOfType<NavigationOptions>().LoadThisLevel("SceneE-E");
        }
    }

    // If we want to allow resetting of highscore
    public void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }
}
