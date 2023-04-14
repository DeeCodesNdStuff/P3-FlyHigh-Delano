using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Vector3 player;
    public Vector3 check1;
    public Vector3 check2;
    public int count;
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "check1")
        {
            check1 = collider.transform.position;
      //      print("hasCollided");
            count = 1;
        }
        if (collider.gameObject.tag == "check2")
        {
            check2 = collider.transform.position;
            count = 2;
        }

        
    }
}
