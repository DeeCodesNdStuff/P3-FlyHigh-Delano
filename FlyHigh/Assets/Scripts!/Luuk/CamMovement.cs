using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public float cy;
    public float speedH;
    public float speedV;
    private float rX;
    private float rY;
    public Transform tar;
    public float dis;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        speedH = 5f;
        speedV = 3f;
        dis= 3f;
    }

    // Update is called once per frame
    void Update()
    {
        rX -= speedH * Input.GetAxis("Mouse Y");
        rY += speedV * Input.GetAxis("Mouse X");
        rX = Mathf.Clamp(rX, -10f, 30f);
        transform.eulerAngles = new Vector3(rX, rY, 0);
        transform.position = tar.position - transform.forward * dis ;
    }
}
