using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShootingShotgun : MonoBehaviour
{
    public Shotgun shootGuns;

    public RaycastHit hit;

    public TMP_Text textMeshpr0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shootGuns.currentBullets -=1;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 1000))
            {
                if (hit.transform.gameObject.tag == "Enemy")
                {
                    Destroy(hit.transform.gameObject);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            shootGuns.currentBullets = shootGuns.maxBullets;
        }

        if(shootGuns.equipped == true)
        {
            textMeshpr0.enabled = true;
            if (shootGuns.currentBullets == 0)
            {
                textMeshpr0.text = shootGuns.text[0];
            }
            if (shootGuns.currentBullets > 0)
            {
                textMeshpr0.text = shootGuns.text[1];
            }
        }
        if(shootGuns.equipped == false)
        {
            textMeshpr0.enabled = false;
        }

    }
}
