using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{

    // initally stationary
    private bool isActivated = false;
    private int forwardFrameCount = 0;

    // forward force
    public float forwardForce = 1000f;
    private void Start()
    {
        
    }

    private void Update()
    {
        // if activated then move back and forth
        Debug.Log(isActivated);
        if (isActivated)
        {
            if (forwardFrameCount < 100) {
                transform.Translate(new Vector3(1 * Time.deltaTime, 0, 0));
            }
            else if (forwardFrameCount < 200)
            {
                transform.Translate(new Vector3(-1 * Time.deltaTime, 0, 0));
            }
            else {
                forwardFrameCount = 0;
            }
            forwardFrameCount++;
            
        }
        
    }


    public void enableActivate()
    {
        isActivated = true;
    }


}
