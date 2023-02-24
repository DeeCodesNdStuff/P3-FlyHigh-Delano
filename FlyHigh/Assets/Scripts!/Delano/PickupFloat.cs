using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupFloat : MonoBehaviour
{
    public GiveQuest GiveQuests;

    public Vector3 rotation;
    public Vector3 startPos;

    public Vector3 handheldPosition;
    public Vector3 handheldRotation;

    public GameObject pickups;

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

        if(startPos.y > 10)
        {
            startPos.y = 0;

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        GiveQuests.prequisiteItem = true;

        handheldPosition.x = 0.06f;
        handheldPosition.y = -0.04f;
        handheldPosition.z = 1.41f;

        handheldRotation.x = -81.205f;
        handheldRotation.y = 81.043f;
        handheldRotation.z = -78.764f;

        rotation = handheldRotation;
        startPos = handheldPosition;
    }



}

