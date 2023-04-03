using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;

public class DeeMovement : MonoBehaviour
{
    public float hor;
    public float ver;
    public float moveSpd;
    public float cameraSpd;

    public Vector3 vec3;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //WASD
        ver = Input.GetAxis("Vertical");
        vec3.z = ver;

        hor = Input.GetAxis("Horizontal");
        vec3.x = hor;

        transform.Translate(vec3 * moveSpd * Time.deltaTime);
        //mouse

        float h = cameraSpd * Input.GetAxis("Mouse X");
        float v = cameraSpd * Input.GetAxis("Mouse Y");
        transform.Rotate(-v, h, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Space was pressed");
            // transform.localEulerAngles = Vector3.zero;
        }

    }
}
