using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public Animator animator;

    public CircleCollider2D circle;

    public BoxCollider2D ground;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;

    bool light = false;

    bool onGround;

            // Update is called once per frame
            void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("JumpOrNot", true);
        }

        if (Input.GetButtonDown("Light"))
        {
            light = true;
        }
        else if (Input.GetButtonUp("Light"))
        {
            light = false;
        }

     /*   if (circle.IsTouching(ground) == true)
        {
            onGround = true;
        }
        else if (circle.IsTouching(ground) == false)
        {
            onGround = false;
        }

        if (Input.GetButtonDown("Down") && onGround == false)
        {
            circle.enabled = false;
           // onGround = true;
        }

        if (Input.GetButtonUp("Down"))
        {
            circle.enabled = true;
            onGround = true;
        } */

        //-10.42118 <-- 
       
    /* player's position less than this value then onGround = true and         */

    }

    public void OnLanding()
    {
        animator.SetBool("JumpOrNot", false);
    }

    public void OnLighting(bool isLighting)
    {
        animator.SetBool("LightOrNot", isLighting);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, light, jump);
        jump = false;
    }
}
