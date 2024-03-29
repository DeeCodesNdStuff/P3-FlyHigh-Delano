using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "shotgun", menuName = "Single-Barrel shotgun")]
public class Shotgun : Ranged
{
    public int spread;
    public int damage;
    public int reloadSpeed;
    public int maxBullets;
    public int currentBullets;
    public string[] text;

    public bool equipped;
}
