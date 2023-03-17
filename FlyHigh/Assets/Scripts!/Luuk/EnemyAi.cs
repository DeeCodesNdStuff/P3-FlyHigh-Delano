using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    public float look;
    public float distance; 
    public NavMeshAgent enemy;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        look = 7f;
        enemy = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, player.position);
        if (distance <= look)
        {
          enemy.SetDestination(player.position);
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, look);
    }
}
