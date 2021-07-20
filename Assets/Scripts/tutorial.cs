using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tutorial : MonoBehaviour
{
    public PlayerCollision p1;
    public PlayerCollision p2;
    private bool isComplete = false;

    public Text SkipStart;
    public Text Instruction;

    //public Image Ab;
    public GameObject A;
    public GameObject S;
    public GameObject D;
    public GameObject W;

    public GameObject Left;
    public GameObject Down;
    public GameObject Right;
    public GameObject Up;

    Color32 original = new Color32(255, 255, 255, 211);
    Color32 pressed = new Color32(255, 255, 225, 100);

    public static int count = 3;

    private void Start()
    {
        Instruction.text = "Shoot all treasure boxes and then move to the flag";
        count = 3;
        isComplete = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            A.GetComponent<SpriteRenderer>().color = pressed;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {

            A.GetComponent<SpriteRenderer>().color = original;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            S.GetComponent<SpriteRenderer>().color = pressed;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {

            S.GetComponent<SpriteRenderer>().color = original;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            D.GetComponent<SpriteRenderer>().color = pressed;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {

            D.GetComponent<SpriteRenderer>().color = original;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            W.GetComponent<SpriteRenderer>().color = pressed;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {

            W.GetComponent<SpriteRenderer>().color = original;
        }


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Left.GetComponent<SpriteRenderer>().color = pressed;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {

            Left.GetComponent<SpriteRenderer>().color = original;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Down.GetComponent<SpriteRenderer>().color = pressed;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {

            Down.GetComponent<SpriteRenderer>().color = original;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Right.GetComponent<SpriteRenderer>().color = pressed;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {

            Right.GetComponent<SpriteRenderer>().color = original;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Up.GetComponent<SpriteRenderer>().color = pressed;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {

            Up.GetComponent<SpriteRenderer>().color = original;
        }

        if (count == 0)
        {
            Instruction.text = "Both players should move to the flag";
        }

        if (p1.isCorrectA && p2.isCorrectA)
        {
            if (isComplete == false && count == 0)
            {
                isComplete = true;
                //question.text = "Answer is Correct!";
                Invoke("NextLevel", 1f);
                FindObjectOfType<LevelLoader>().AllowTransit("Pass");
            }
        }
    }

     public void NextLevel()
     {
          FindObjectOfType<NavigationOptions>().ReturnToMainMenu();  
     }      
   
  
}