using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
   public float speed;
   public Rigidbody2D rbody;
   public Vector3 startPosition;
   public Vector2 pausedVel;

   void Start(){
      startPosition = transform.position;
      Kickoff();
   }

   private void Kickoff(){
      float x = Random.Range(0,2)==0?-1:1;
      float y = Random.Range(0,2)==0?-1:1;
      rbody.velocity = (new Vector2(speed*x,speed*y));
   }
   public void Pause(){
      pausedVel = rbody.velocity;
      rbody.velocity = Vector2.zero;
   }
   public void Unpause(){
      rbody.velocity = pausedVel;
   }
   public void Reset(){
      rbody.velocity = Vector2.zero;
      transform.position = startPosition;
      Kickoff();
   }
}
