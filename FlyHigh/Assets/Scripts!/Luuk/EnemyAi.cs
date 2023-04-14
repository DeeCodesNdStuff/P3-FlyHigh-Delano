using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    public float look;
    public float att;
    public float dis;
    public float fireRa;
    public float fireNe;
    public int wayPointNu;
    public NavMeshAgent enemy;
    public Transform player;
    public Transform gun;
    public GameObject bullet;
    public GameObject clone;
    public Transform[] wayPoint;
    void Start()
    {
        look = 10f;
        att = 7f;
        fireNe = 0f;
        fireRa = 2f;
        wayPointNu = 0;
        enemy.GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        dis = Vector3.Distance(transform.position, player.position);
        if (dis <= look)
        {
            enemy.SetDestination(player.position);
            if (dis <= att)
            {
                if (fireNe <=0)
                {
                    fireNe = 5f / fireRa;
                    clone = Instantiate(bullet, gun.position, transform.rotation);
                    clone.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                }
                fireNe -= Time.deltaTime;
            }
        }
        if (dis >= look)
        {
            enemy.SetDestination(wayPoint[wayPointNu].position);
            if(enemy.remainingDistance <= enemy.stoppingDistance)
            {
                wayPointNu++;
                if (wayPointNu == wayPoint.Length)
                {
                    wayPointNu = 0;
                }
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, look);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, att);
    }
}
