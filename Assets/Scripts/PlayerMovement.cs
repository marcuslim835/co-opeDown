using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;

    public bool jump = false;
    public bool crouch = false;
    public float horizontalMove = 0f;



    // Update is called once per frame
    public void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal_P1") * runSpeed;
        //Debug.Log(Input.GetAxisRaw("Horizontal_P1"));

        if (Input.GetButtonDown("Jump_P1"))
        {
            jump = true;
        }

        //if(Input.GetButtonDown("Crouch"))
        //{
        //    crouch = true;
        //} else if (Input.GetButtonUp("Crouch"))
        //{
        //    crouch = false;
        //}
 
    }

    public void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        crouch = false;
    }
}
