using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_tut : MonoBehaviour
{
    public int health;

    private void Start()
    {
       
    }
    //public GameObject deathEffect;

    public void TakeDamage(int damage)
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
        //PlatformGameLogicBoss.scoreValue += 1;
        tutorial.count--;

    }

    public void SetHealth(int h)
    {
        health = h;
    }
}
