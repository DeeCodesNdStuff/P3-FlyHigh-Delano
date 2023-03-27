using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class EquipItems : MonoBehaviour
{
    public Shotgun shotsgut;

    public GameObject clipingPoint;
    public GameObject item;


    public RaycastHit hit;

    // Update is called once per frame
    void Update()
    {

        if (shotsgut.equipped == true)
        {
            item.transform.position = clipingPoint.transform.position;

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
    }
}
