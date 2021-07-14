using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    Vector2 whereToSPawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    public int numberOfMonsters;
    int count = 0;
    public PlatformGameLogicBoss platformGameLogicBoss;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count < numberOfMonsters)
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                randX = Random.Range(-9.00f, 3.00f);
                whereToSPawn = new Vector2(randX, transform.position.y);
                Instantiate(enemy, whereToSPawn, Quaternion.identity);
                count++;
            }
           
        } else
        {
            //platformGameLogicBoss.SetComplete();
        }
    }
}
