using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveLoadManager : MonoBehaviour
{
    public GameObject canvas;
    public Text save0level;
    public Text save0score;
    public Text save1level;
    public Text save1score;
    public Text save2level;
    public Text save2score;

    public Button save0button;
    public Button load0button;
    public Text save0word;
    public Button save1button;
    public Button load1button;
    public Text save1word;
    public Button save2button;
    public Button load2button;
    public Text save2word;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.HasKey("Save0Level"))
        {
            string sceneName = PlayerPrefs.GetString("Save0Level");
            load0button.interactable = true;
            if (PlayerPrefs.HasKey("Save0Mode"))
            {
                save0level.text = PlayerPrefs.GetString("Save0Mode") + " Mode: ";
            }
            else
            {
                save0level.text = "";
            }
            save0level.text += "Level " + sceneName.Substring(sceneName.Length - 3);
            if (PlayerPrefs.HasKey("Save0Difficulty"))
            {
                save0level.text += " (" + PlayerPrefs.GetString("Save0Difficulty") + ")";
            }
            save0score.text = PlayerPrefs.GetInt("Save0Score").ToString();
        }
        else
        {
            load0button.interactable = false;
            save0level.text = "No save file on this slot";
            save0score.text = "";
        }
        if (PlayerPrefs.HasKey("Save1Level"))
        {
            string sceneName = PlayerPrefs.GetString("Save1Level");
            load1button.interactable = true;
            if (PlayerPrefs.HasKey("Save1Mode"))
            {
                save1level.text = PlayerPrefs.GetString("Save1Mode") + " Mode: ";
            }
            else
            {
                save1level.text = "";
            }
            save1level.text += "Level " + sceneName.Substring(sceneName.Length - 3);
            if (PlayerPrefs.HasKey("Save1Difficulty"))
            {
                save1level.text += " (" + PlayerPrefs.GetString("Save1Difficulty") + ")";
            }
            save1score.text = PlayerPrefs.GetInt("Save1Score").ToString();
        }
        else
        {
            load1button.interactable = false;
            save1level.text = "No save file on this slot";
            save1score.text = "";
        }
        if (PlayerPrefs.HasKey("Save2Level"))
        {
            string sceneName = PlayerPrefs.GetString("Save2Level");
            load2button.interactable = true;
            if (PlayerPrefs.HasKey("Save2Mode"))
            {
                save2level.text = PlayerPrefs.GetString("Save2Mode") + " Mode: ";
            }
            else
            {
                save2level.text = "";
            }
            save2level.text += "Level " + sceneName.Substring(sceneName.Length - 3);
            if (PlayerPrefs.HasKey("Save2Difficulty"))
            {
                save2level.text += " (" + PlayerPrefs.GetString("Save2Difficulty") + ")";
            }
            save2score.text = PlayerPrefs.GetInt("Save2Score").ToString();
        }
        else
        {
            load2button.interactable = false;
            save2level.text = "No save file on this slot";
            save2score.text = "";
        }
    }

    public void OpenSaveMenuFromMain()
    {
        FindObjectOfType<SaveLoadManager>().save0word.text = "Delete Save";
        FindObjectOfType<SaveLoadManager>().save1word.text = "Delete Save";
        FindObjectOfType<SaveLoadManager>().save2word.text = "Delete Save";
        FindObjectOfType<SaveLoadManager>().canvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void OpenSaveMenu()
    {
        FindObjectOfType<OptionsMenu>().CloseOptions();
        save0word.text = "Save";
        save1word.text = "Save";
        save2word.text = "Save";
        canvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseSaveMenu()
    {
        canvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void SaveGame(int slotNum)
    {
        string sceneName = SceneManager.GetActiveScene().name;
        if (save0word.text == "Delete Save")
        {
            PlayerPrefs.DeleteKey("Save" + slotNum + "Level");
            PlayerPrefs.DeleteKey("Save" + slotNum + "Score");
            PlayerPrefs.DeleteKey("Save" + slotNum + "Mode");
            PlayerPrefs.DeleteKey("Save" + slotNum + "Difficulty");
        }
        else
        {
            int score = FindObjectOfType<ScoreTimeManager>().GetScore();
            PlayerPrefs.SetString("Save" + slotNum + "Level", sceneName);
            PlayerPrefs.SetInt("Save" + slotNum + "Score", score);
            PlayerPrefs.SetString("Save" + slotNum + "Mode", PlayerPrefs.GetString("GameMode"));
            PlayerPrefs.SetString("Save" + slotNum + "Difficulty", PlayerPrefs.GetString("GameDifficulty"));
            PlayerPrefs.Save();
        }
    }

    public void LoadGame(int slotNum)
    {
        if (PlayerPrefs.HasKey("Save" + slotNum + "Level"))
        {
            string sceneName = PlayerPrefs.GetString("Save" + slotNum + "Level");
            int score = PlayerPrefs.GetInt("Save" + slotNum + "Score");
            FindObjectOfType<NavigationOptions>().LoadThisLevel(sceneName);
            FindObjectOfType<ScoreTimeManager>().SetScore(score);
            PlayerPrefs.SetString("GameMode", PlayerPrefs.GetString("Save" + slotNum + "Mode"));
            PlayerPrefs.SetString("GameDifficulty", PlayerPrefs.GetString("Save" + slotNum + "Difficulty"));
            CloseSaveMenu();
        }
    }

    public void ResetSaveGames()
    {
        PlayerPrefs.DeleteAll();
    }
}
