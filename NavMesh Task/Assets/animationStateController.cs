using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    int isWalkingHash;
    void Start()
    {
        // Get the animator component within the Unity Project
        animator = GetComponent<Animator>();
        // Converts string type to its own type
        isWalkingHash = Animator.StringToHash("isWalking");
    }

    // Update is called once per frame
    void Update()
    {
        // get the bool for if player is walking to reduce frame updates constantly
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isRunning = animator.GetBool("isRunning");
        // get user input
        bool forwardPressed = Input.GetKey("w");

        // get run input
        bool runPressed = Input.GetKey("left shift");


        // if player is not walking yet and user presses w, then start walking
        if (!isWalking && forwardPressed)
        {
            animator.SetBool(isWalkingHash, true);
        }

        // opposite of above logic
        if (isWalking && !forwardPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }

        // is running
        if (!isRunning && forwardPressed && runPressed)
        {
            animator.SetBool("isRunning", true);
        }

        // is not running
        if(isRunning && (!isWalking || !runPressed))
        {
            animator.SetBool("isRunning", false);
        }
    }
}
