using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool isGrounded;
    public float speed;
    public float speedV;
    public int speedG;
    public float jumpF;
    public float hor;
    public float ver;
    private float rY;
    public Vector3 move;
    public Vector3 jump;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        speed = 6f;
        jumpF = 2.1f;
        speedV = 3f;
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.1f, 0.0f);
        isGrounded = true;
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        move.x = hor;
        move.z = ver;
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        transform.Translate(move * Time.deltaTime * speed);

        rY += speedV * Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, rY, 0);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpF, ForceMode.Impulse);
            isGrounded = false;
        }

        if (isGrounded == true)
        {
            rb.drag = 0f;
        }

        if (Input.GetKeyDown(KeyCode.Q) && isGrounded == false)
        {
            rb.drag = 5f;

            if (Input.GetKeyDown(KeyCode.W))
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(speedG,0,0));
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, speedG));
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(-speedG, 0, 0));
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -speedG));
            }
        }   
    }
}
