using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RickMovement : MonoBehaviour
{
    public CharacterController2D controller;
    private float horizontalMove = 0f;
    public float speed = 40f;
    private bool jump;
    public Joystick joystick;

    // Update is called once per frame
    void Update()
    {
        // horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        horizontalMove =joystick.Horizontal * speed;

        if (Input.GetButtonDown("Jump")){
            jump = true;
        }
    }

    public void Jump(){
        jump = true;
    }

    void FixedUpdate(){
        controller.Move(horizontalMove * Time.fixedDeltaTime,false,jump);
        jump = false;
    }
}
