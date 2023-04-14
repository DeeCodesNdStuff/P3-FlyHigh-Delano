using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public Checkpoint cps;
    public void update()
    {
        int checkPoint = cps.count;

        if (gameObject.tag == "deadstate")
        {
            if (checkPoint == 1)
            {
                transform.position = cps.check1;

            }
            if (cps.count == 2)
            {
                transform.position = cps.check2;
            }
        }
    }
}
