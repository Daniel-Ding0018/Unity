using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RedAgentNavigation : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent Agent;
    private Animator animator;
    private bool isFollowPlayer;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        // while the bool is active, chase player
        if (isFollowPlayer)
        {
            Agent.destination = player.position;
        }
    }

    public void enableFollow()
    {
        isFollowPlayer = true;
        animator.SetBool("isFollowPlayer", true);
    }

}
