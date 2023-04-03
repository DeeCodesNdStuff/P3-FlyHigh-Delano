using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCheck : MonoBehaviour
{
    public float speed;
    public float ver;
    public float hor;
    public Vector3 vec3;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = -Input.GetAxis("Vertical");

        vec3.z = hor;
        vec3.x = ver;

        transform.Translate(vec3 * speed * Time.deltaTime);
    }
  
}
