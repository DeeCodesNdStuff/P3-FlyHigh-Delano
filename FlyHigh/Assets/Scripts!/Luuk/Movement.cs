using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public bool isGrounded;
    public bool isRunning;
    public float speed;
    public float speedCa;
    public float speedGi;
    public float jumpF;
    public float hor;
    public float ver;
    private float rY;
    public Vector3 move;
    public Vector3 jump;
    public Rigidbody rb;
    public Animator animator;
    void Start()
    {
        speed = 6f;
        speedCa = 3f;
        speedGi = 5f;
        jumpF = 2.3f;
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        jump = new Vector3(0.0f, 2.3f, 0.0f);
    }
    void OnCollisionStay()
    {
        isGrounded = true;
        rb.drag = 0f;
    }
    void Update()
    {
        //movement
        move.x = hor;
        move.z = ver;
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        transform.Translate(move * speed * Time.deltaTime);
        
        //animation
        if (Input.GetKey(KeyCode.W) && isGrounded)
        {
            animator.SetBool("IsRunning", false);
            animator.SetBool("IsWalking", true);
            animator.SetBool("IsIdle", false);
            if(Input.GetKey(KeyCode.LeftShift) && isGrounded)
            {
                animator.SetBool("IsRunning", true);
                animator.SetBool("IsWalking", false);
                animator.SetBool("IsIdle", false);
            }
        }
        else if(Input.GetKey(KeyCode.A) && isGrounded)
        {
            animator.SetBool("IsRunning", false);
            animator.SetBool("IsWalking", true);
            animator.SetBool("IsIdle", false);
            if (Input.GetKey(KeyCode.LeftShift) && isGrounded)
            {
                animator.SetBool("IsRunning", true);
                animator.SetBool("IsWalking", false);
                animator.SetBool("IsIdle", false);
            }
        }
        else if (Input.GetKey(KeyCode.S) && isGrounded)
        {
            animator.SetBool("IsRunning", false);
            animator.SetBool("IsWalking", true);
            animator.SetBool("IsIdle", false);
            if (Input.GetKey(KeyCode.LeftShift) && isGrounded)
            {
                animator.SetBool("IsRunning", true);
                animator.SetBool("IsWalking", false);
                animator.SetBool("IsIdle", false);
            }
        }
        else if (Input.GetKey(KeyCode.D) && isGrounded)
        {
            animator.SetBool("IsRunning", false);
            animator.SetBool("IsWalking", true);
            animator.SetBool("IsIdle", false);
            if (Input.GetKey(KeyCode.LeftShift) && isGrounded)
            {
                animator.SetBool("IsRunning", true);
                animator.SetBool("IsWalking", false);
                animator.SetBool("IsIdle", false);
            }
        }
        else
        {
            animator.SetBool("IsRunning", false);
            animator.SetBool("IsWalking", false);
            animator.SetBool("IsIdle", true);
        }

        //dash
        if (Input.GetKey(KeyCode.LeftShift) && isGrounded)
        {
            isRunning = true;
            speed = 8f;
        }
        else
        {
            isRunning = false;
            speed = 6f;
        }

        //camera
        rY += speedCa * Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, rY, 0);

        //jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpF, ForceMode.Impulse);
            isGrounded = false;
        }

        //gliding
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == false)
        {
            rb.drag = 5f;

            if (Input.GetKeyDown(KeyCode.W))
            {
               rb.AddForce(new Vector3(speedGi,0,0));
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                rb.AddForce(new Vector3(0, 0, speedGi));
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                rb.AddForce(new Vector3(-speedGi, 0, 0));
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                rb.AddForce(new Vector3(0, 0, -speedGi));
            }
        }   
    }
}
