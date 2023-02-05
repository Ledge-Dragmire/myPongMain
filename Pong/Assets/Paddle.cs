using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
   public bool isPlayer1;
   public float speed;
   public Rigidbody2D rbody;
   public Vector3 startPosition;
   public float tolerance;
   private float direction;
   
   void Start(){
      startPosition = transform.position;
      rbody.velocity = Vector2.zero;
   }

   void Update(){
      if(isPlayer1){
         direction = Input.GetAxisRaw("Vertical");
      }else{//bot behavior
         if(GameObject.Find("ball").GetComponent<Ball>().transform.position.y>transform.position.y+tolerance){
            direction = 1;
         }else{
            if(GameObject.Find("ball").GetComponent<Ball>().transform.position.y<transform.position.y-tolerance){
               direction = -1;
            }else{
               direction = 0;
            }
         }
      }
      if(!GameObject.Find("GameManager").GetComponent<GameManager>().paused){   
         rbody.velocity = Vector2.up * speed * direction;
      }
      else{
         rbody.velocity = Vector2.zero;
      }
   }
   public void Reset(){
      rbody.velocity = Vector2.zero;
      transform.position = startPosition;
   }
}
