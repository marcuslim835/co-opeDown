using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCollision : MonoBehaviour
{
    private int numToAdd;
    //public bool addNumber = false;
    public bool isNegative;
    public int maxNum;
    public int minNum;
    public int maxMultiplier;
    public int minMultiplier;

    public PlusMinusGameLogic gameLogic;
    public Text numValue;

    void Start()
    {
        numToAdd = Random.Range(minNum, maxNum);
        if (isNegative && PlayerPrefs.GetString("GameDifficulty") == "Easy")
        {
            numToAdd *= -1;
            numValue.text = numToAdd.ToString();
            gameLogic.ModifyTarget(Random.Range(minMultiplier, maxMultiplier) * numToAdd);
        }
        else if (isNegative && PlayerPrefs.GetString("GameDifficulty") == "Normal")
        {
            numToAdd *= -5;
            numValue.text = numToAdd.ToString();
            gameLogic.ModifyTarget(Random.Range(minMultiplier, maxMultiplier) * numToAdd);
        }
        else if (isNegative && PlayerPrefs.GetString("GameDifficulty") == "Hard")
        {
            numValue.text = "x" + numToAdd.ToString();
            int multiplier = getPower(numToAdd, Random.Range(minMultiplier, maxMultiplier));
            gameLogic.MultiplyTarget(multiplier);
        }
        else
        {
            numValue.text = "+" + numToAdd.ToString();
            gameLogic.ModifyTarget(Random.Range(minMultiplier, maxMultiplier) * numToAdd);
        }
    }

    private int getPower(int baseNum, int power)
    {
        int ans = baseNum;
        if (power == 0)
        {
            return 1;
        }
        for (int i = 1; i < power; i++)
        {
            ans *= baseNum;
        }
        return ans;
    }

    void OnTriggerEnter2D(Collider2D colliderInfo)
    {
        if (colliderInfo.name == "bullet_Spirite(Clone)")
        {
            if (isNegative && PlayerPrefs.GetString("GameDifficulty") == "Hard")
            {
                gameLogic.MultiplySum(numToAdd);
            }
            else
            {
                gameLogic.ChangeSum(numToAdd);
            }  
        }
    }
}
