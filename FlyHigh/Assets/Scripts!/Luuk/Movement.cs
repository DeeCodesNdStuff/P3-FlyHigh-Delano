using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool isGrounded;
    public float speed;
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
        jumpF = 2.1f;
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.1f, 0.0f);
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
        cx = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * cx);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpF, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
