using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    public void OpenOptions()
    {
        canvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseOptions()
    {
        canvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        FindObjectOfType<NavigationOptions>().ReturnToMainMenu();
        canvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        FindObjectOfType<NavigationOptions>().QuitGame();
        Time.timeScale = 1;
    }
}
