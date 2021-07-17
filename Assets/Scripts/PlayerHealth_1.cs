using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth_1 : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public HeathBar healthBar;

    public PlatformGameLogicBoss platformGameLogicBoss;

    // Start is called before the first frame update
    void Start()
    {
        //maxHealth = FindObjectOfType<ScoreTimeManager>().GetScore();
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth); 
    }

    public void DecreaseHealth()
    {
        currentHealth -= 1;
        if (currentHealth <= 0)
        {
            platformGameLogicBoss.KillPlayer();
            Die();
        }
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.SetHealth(currentHealth);
    }

    public void Die()
    {
        // destroy player
        
        Destroy(gameObject);
       
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            //Debug.Log(enemy.name);
            DecreaseHealth();
            PlatformGameLogicBoss.scoreValue -= 1;
            enemy.Die();
            
        }

        Debug.Log(hitInfo.name);
    }
}
