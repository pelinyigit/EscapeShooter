using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask WhatIsPlayer;

    //State
    public float sightRange;
    public bool playerInSightRange;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, WhatIsPlayer);

        if(playerInSightRange == true)
        {
            ChasePlayer();
        }
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }
}
