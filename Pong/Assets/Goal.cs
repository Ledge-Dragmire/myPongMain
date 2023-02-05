using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
   public bool p1Goal;

   private void OnTriggerEnter2D(Collider2D collision){
      if(collision.gameObject.CompareTag("Ball")){
         if(p1Goal){
            GameObject.Find("GameManager").GetComponent<GameManager>().P2Scored();
         }else{
            GameObject.Find("GameManager").GetComponent<GameManager>().P1Scored();
         }
      }
   }
}
