using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int health;

    private void Start()
    {
        // Difficulty levels
        if (PlayerPrefs.GetString("GameDifficulty") == "Easy")
        {
            health = 50;

            Debug.Log("50");
        }
        else if (PlayerPrefs.GetString("GameDifficulty") == "Normal")
        {
            health = 100;

            Debug.Log("100");
        }
        else
        {
            health = 150;

            Debug.Log("150");
        }
    }
    //public GameObject deathEffect;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        // death effect
        //Instantiate(deathEffect, transform.position, Quaternion.identity); 

        // destroy enemy from scene
        Destroy(gameObject);
        PlatformGameLogicBoss.scoreValue += 1;
        
    }

    public void SetHealth(int h)
    {
        health = h;
    }

   
}
