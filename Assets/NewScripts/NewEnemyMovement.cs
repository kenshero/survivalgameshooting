using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewEnemyMovement : MonoBehaviour {
    Transform player;               // Reference to the player's position.
    NewPlayerHealth playerHealth;      // Reference to the player's health.
    NewEnemyHealth enemyHealth;        // Reference to this enemy's health.
    NavMeshAgent nav;               // Reference to the nav mesh agent.

    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<NewPlayerHealth>();
        enemyHealth = GetComponent<NewEnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            nav.SetDestination(player.position);
        }
        else
        {
            nav.enabled = false;
        }
    }
}
