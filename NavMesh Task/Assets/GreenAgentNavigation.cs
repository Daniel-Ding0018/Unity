using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GreenAgentNavigation : MonoBehaviour
{

    public Transform player;
    public NavMeshAgent Agent;
    private Animator animator;

    // bool to determine if chase player
    private bool isFollowPlayer = true;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isFollowPlayer", true);
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
    // disable the follow bool
    public void disableFollow()
    {
        isFollowPlayer = false;
        animator.SetBool("isFollowPlayer", false);
        animator.SetBool("isDead", true);
    }
}
