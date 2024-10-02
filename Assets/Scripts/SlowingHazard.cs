using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowingHazard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.CompareTag("Player")){
            Other.GetComponent<MovementController>().speed-=4f;
            if (Other.GetComponent<MovementController>().speed<0)
            {
                Other.GetComponent<MovementController>().speed = 0;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D Other)
    {
        if (Other.CompareTag("Player")){
            Other.GetComponent<MovementController>().speed+=4f;
        }
    }
}
