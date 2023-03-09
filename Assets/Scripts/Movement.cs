using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator animator;
     public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    public Controller controller;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        if (Input.GetButtonDown("Jump"))
        {
            if (!animator.GetBool("IsFall"))
            {
                jump = true;
                animator.SetBool("IsJump", true);
            }
            
        }
    }
    public void OnLand()
    {
        animator.SetBool("IsJump", false);
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
