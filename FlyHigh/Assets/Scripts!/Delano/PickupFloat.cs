using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupFloat : MonoBehaviour
{
    public Vector3 rotation;
    public Vector3 startPos;

    public float amplitude
;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float y = startPos.y + (Mathf.Sin(Time.time) * amplitude);
        //float x = startPos.x + Mathf.Sin(Time.time);
        transform.position = new Vector3(startPos.x, y, startPos.z);

        transform.Rotate(rotation * Time.deltaTime);
    }
}

