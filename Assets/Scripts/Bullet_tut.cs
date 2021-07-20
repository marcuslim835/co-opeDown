using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_tut : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public int damage;
    //public GameObject impactEfect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy_tut enemy = hitInfo.GetComponent<Enemy_tut>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        //Instantiate(impactEfect, transform.position, transform.rotation);
        //Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
}

