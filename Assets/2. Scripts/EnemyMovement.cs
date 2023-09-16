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
    }

    void Update()
    {
        agent.destination = enemy.Player.transform.position;
    }
}
