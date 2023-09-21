using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private Enemy enemy;
    private NavMeshAgent agent;
    
    void Start()
    {
        enemy = GetComponent<Enemy>();
        agent = GetComponent<NavMeshAgent>();

        agent.destination = enemy.Player.transform.position;
    }

    void Update()
    {
        if(agent.destination != Vector3.zero)
        {
            if(Vector3.Distance(transform.position, agent.destination) < 4)
            {
                agent.destination = enemy.Player.transform.position;
            }
        }
    }
}
