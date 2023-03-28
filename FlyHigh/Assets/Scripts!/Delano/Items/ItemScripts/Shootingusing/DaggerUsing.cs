using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class DaggerUsing : MonoBehaviour
{
    
    public Dagger sliceNddice;

    public RaycastHit hit;

    public TMP_Text textMeshpr1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(transform.position, transform.up, out hit, 10))
            {
                if (hit.transform.gameObject.tag == "Enemy")
                {
                    Destroy(hit.transform.gameObject);
                }
            }
        }

        if (sliceNddice.equipped == true)
        {
            textMeshpr1.enabled = true;
            textMeshpr1.text = sliceNddice.text[0];
        }
    }
}
