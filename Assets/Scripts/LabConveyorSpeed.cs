using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabConveyorSpeedUp : MonoBehaviour
{
private void OnTriggerEnter2D(Collider2D Other)
{
   if (Other.CompareTag("Player")){
      Other.GetComponent<MovementController>().speed+=3f;
      if (Other.GetComponent<MovementController>().speed<0){
         Other.GetComponent<MovementController>().speed = 0;
      }
   } 
} 


private void OnTriggerExit2D(Collider2D Other)
{
   if(Other.CompareTag("Player")){
      Other.GetComponent<MovementController>().speed-=3f;
   }
}

}