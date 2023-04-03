using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Death : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        collider.gameObject.tag = "deadstate";
    }
}
