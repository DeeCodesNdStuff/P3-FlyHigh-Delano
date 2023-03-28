using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class EquipItems : MonoBehaviour
{
    public Shotgun shotsgut;
    public Dagger sliceNddice;

    public GameObject player;
    public GameObject clipingPoint;
    public GameObject clipingPoint1;

    public GameObject item1;
    public GameObject item;


    public RaycastHit hit;

    // Update is called once per frame
    void Update()
    {

        if (shotsgut.equipped == true)
        {
            item.transform.position = clipingPoint.transform.position;
            item.transform.rotation = clipingPoint.transform.rotation;
            
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            shotsgut.equipped = true;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
            {
                if (item.tag == "ableToPickup")
                {
                    item.transform.position = clipingPoint.transform.position;
                }
            }
        }

        if (sliceNddice.equipped == true)
        {
            item1.transform.position = clipingPoint1.transform.position;
            item1.transform.rotation = clipingPoint1.transform.rotation;

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            sliceNddice.equipped = true;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
            {
                if (item.tag == "ableToPickup")
                {
                    item1.transform.position = clipingPoint.transform.position;
                }
            }
        }
    }
}
