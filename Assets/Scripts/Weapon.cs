using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float fireRate = 0.1f;
    private bool allowFire = true;

    Animator animator;

    //// Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1_P1") && allowFire)
        {
            //Play animation
            StartCoroutine(Shoot());
            animator.SetBool("IsShooting", true);
        } 
        else
        {
            animator.SetBool("IsShooting", false);
        }
    }

    IEnumerator Shoot()
    {
        //Limit Rate of Firing
        allowFire = false;
        //Give time for animation to play
        yield return new WaitForSeconds(0.15f);
        // Shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Physics2D.Raycast(firePoint.position, firePoint.right);
        //Wait for next shot
        yield return new WaitForSeconds(fireRate);
        allowFire = true;
    }
}
 