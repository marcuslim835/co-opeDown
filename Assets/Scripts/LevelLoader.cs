using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transitionPass; // animation for correct
    public Animator transitionFail; // animation for failing stage
    public Animator transitionNormal; // animation for game over

    //public bool allowTransition = false;
    //static string result = "";
    //public float transitionTime = 2f;

    //public GameObject canvasPassFade;

    //void Update()
    //{
    //    //if (Input.GetKeyDown(KeyCode.Space))
    //    //{
    //    //    LoadNextLevel();
    //    //}

    //    if (allowTransition)
    //    {
    //        Debug.Log("hihi");
    //        LoadNextLevel();
    //    }
    //}

    //public void LoadNextLevel() 
    //{
    //    // if pass the stage
    //    DontAllowTransit();
    //    LoadLevel();
    //    //StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    //}

    ////IEnumerator LoadLevel(int levelIndex)
    //public void LoadLevel()
    //{
    //    // Play animation
    //    if (result == "Pass")
    //    {
    //        result = "";
    //        transitionPass.SetTrigger("Start");
    //    } 
    //    else
    //    {
    //        result = "";
    //        transitionFail.SetTrigger("Start");
    //    }

    //    // Wait
    //    //yield return new WaitForSeconds(transitionTime);

    //    // Load Scene
    //    //SceneManager.LoadScene(levelIndex);
    //    //FindObjectOfType<NavigationOptions>().LoadNextLevel();
    //}


    public void AllowTransit(string outcome)
    {
        Debug.Log("Transition NOW!");
        //allowTransition = true;
        //result = outcome;
        if (outcome == "Pass")
        {
            transitionPass.SetTrigger("Start");
            Invoke("DontAllowPass", 1f);
        }
        else if (outcome == "Fail")
        {
            transitionFail.SetTrigger("Start");
            Invoke("DontAllowFail", 1f);
        }
    }

    public void DontAllowPass()
    {
        transitionPass.ResetTrigger("Start");
    }

    public void DontAllowFail()
    {
        transitionFail.ResetTrigger("Start");
    }
}
