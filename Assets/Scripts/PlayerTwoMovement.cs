using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;

    public bool jump = false;
    public bool crouch = false;
    public float horizontalMove = 0f;

    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    public void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal_P2") * runSpeed;
        //Debug.Log(Input.GetAxisRaw("Horizontal_P2"));

        if (Input.GetButtonDown("Jump_P2"))
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
