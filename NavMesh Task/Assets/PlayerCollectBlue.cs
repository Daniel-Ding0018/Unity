using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollectBlue : MonoBehaviour
{
    public GameObject BlueBox;


    private void OnCollisionEnter(Collision collision)
    {
        // when collision happens
        if(collision.gameObject.name == "Player")
        {
            BlueBox.SetActive(false);
            FindObjectOfType<PinkAgentNavigation>().disableFollow();
            FindObjectOfType<GreenAgentNavigation>().disableFollow();
            FindObjectOfType<RedAgentNavigation>().enableFollow();
            FindObjectOfType<BlockMovement>().enableActivate();
        }

    }
}
