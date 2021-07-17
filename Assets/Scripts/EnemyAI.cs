using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;


public class EnemyAI : MonoBehaviour
{
    //public Transform target;

    // the 2 players inside this targetList
    //public List<Transform> targetList = new List<Transform>(2);
    public GameObject[] tList = new GameObject[2];
 
    public float speed;
    public float nextWaypointDistance = 2f;

    public Transform enemyGFX;

    Path path;
    int currentWaypoint = 0;
    bool reachedEndOfPath = false;

    Seeker seeker;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating("UpdatePath", 0f, .5f);

        // Difficulty levels
        if (PlayerPrefs.GetString("GameDifficulty") == "Easy")
        {
            speed = 350;
            nextWaypointDistance = 1f;
            Debug.Log("easy");
        }
        else if (PlayerPrefs.GetString("GameDifficulty") == "Normal")
        {
            speed = 450;
            nextWaypointDistance = 1.1f;
            Debug.Log("normal");
        }
        else
        {
            speed = 550;
            nextWaypointDistance = 1f;
            Debug.Log("hard");
        }

    }

    public void SetSpeed(int s)
    {
        speed = s;
    }

    void UpdatePath()
    {
        if (GameObject.Find("Player_1") != null && GameObject.Find("Player_2") != null)
        { // Both Players Alive
            tList[0] = GameObject.Find("Player_1");
            tList[1] = GameObject.Find("Player_2");
            int num = Random.Range(0, 2);
            if (seeker.IsDone())
                seeker.StartPath(rb.position, tList[num].transform.position, onPathComplete);
        }
        else if (GameObject.Find("Player_1") == null)
        {  // Player One Died...
            tList[0] = GameObject.Find("Player_2");
            if (seeker.IsDone())
                seeker.StartPath(rb.position, tList[0].transform.position, onPathComplete);
        }
        else
        { // Player Two Died...
            tList[0] = GameObject.Find("Player_1");
            if (seeker.IsDone())
                seeker.StartPath(rb.position, tList[0].transform.position, onPathComplete);
        }

        //if (seeker.IsDone())
        //    seeker.StartPath(rb.position, targetList[num].position, onPathComplete);
        //if (seeker.IsDone())
        //    seeker.StartPath(rb.position, target.position, onPathComplete);

        //tList[0] = GameObject.Find("Player_1");
        //tList[1] = GameObject.Find("Player_2");
        //int num = Random.Range(0, 2);
        //if (seeker.IsDone())
        //    seeker.StartPath(rb.position, tList[num].transform.position, onPathComplete);
    }

    void onPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (path == null)
            return;
        if (currentWaypoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        } else
        {
            reachedEndOfPath = false;
        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;

        rb.AddForce(force);

        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);

        if (distance < nextWaypointDistance)
        {
            currentWaypoint++;

        }

        if (rb.velocity.x >= 0.01f)
        {
            enemyGFX.localScale = new Vector3(-1f, 1f, 1f);

        }
        else if (rb.velocity.x <= -0.01f)
        {
            // if travelling to the left, set scale of the enemy to be opp.
            enemyGFX.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
