using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool isGrounded;
    public bool isDash;
    public float speed;
    public float speedD;
    public int speedG;
    public float jumpF;
    public float hor;
    public float ver;
    public float cx;
    public float cm;
    public Vector3 move;
    public Vector3 jump;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        speed = 6f;
        speedD = 10f;
        jumpF = 2.1f;
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.1f, 0.0f);
    }
    void OnCollisionStay()
    {
        isGrounded = true;
        isDash = true;
    }

    // Update is called once per frame
    void Update()
    {
        move.x = hor;
        move.z = ver;
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        transform.Translate(move * Time.deltaTime * speed);        
        cx = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * cx);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpF, ForceMode.Impulse);
            isGrounded = false;
        }

        if (isGrounded == true)
        {
            rb.drag = 0f;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && isGrounded == false)
        {
            rb.drag = 5f;

            if (Input.GetKeyDown(KeyCode.W))
            {
                rb.AddForce(new Vector3(speedG, 0, 0));
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                rb.AddForce(new Vector3(0, 0, speedG));
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                rb.AddForce(new Vector3(-speedG, 0, 0));
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
               rb.AddForce(new Vector3(0, 0, -speedG));
            }
        }
    }
}
