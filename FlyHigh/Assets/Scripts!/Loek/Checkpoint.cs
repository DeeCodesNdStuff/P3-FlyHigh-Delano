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
      //      transform.position = check1;
      //      print("hasCollided");
            count = 1;
        }
        if (collider.gameObject.tag == "check2")
        {
      //      transform.position = check2;
            count = 2;
        }

        
    }
}
