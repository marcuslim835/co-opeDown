using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public bool isCorrectA;
    public bool isCorrectB;

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "CorrectAnswerA")
        {
            isCorrectA = true;
            isCorrectB = false;
            //Debug.Log(collisionInfo.collider.name);
        } 
        else if (collisionInfo.collider.tag == "CorrectAnswerB")
        {
            isCorrectB = true;
            isCorrectA = false;
        } 
        else
        {
            isCorrectA = false;
            isCorrectB = false;
        }
        //Debug.Log(isCorrect);
    }
}
