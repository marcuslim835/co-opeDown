using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppedObjectLogic : MonoBehaviour
{
    public Rigidbody2D rb;
    public float minRandomGravity;
    public float maxRandomGravity;
    public int pointsToAdd;
    // Start is called before the first frame update
    void Start()
    {
        rb.gravityScale = Random.Range(minRandomGravity, maxRandomGravity);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -3.35)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            FindObjectOfType<FallingStageGameLogic>().AddPoints(pointsToAdd);
            Destroy(gameObject);
        }      
    }
}
