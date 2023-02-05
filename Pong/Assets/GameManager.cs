using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour{
   public GameObject ball;

   public GameObject p1paddle;
   public GameObject p1goal;

   public GameObject p2paddle;
   public GameObject p2goal;

   public GameObject p1display;
   public GameObject p2display;
   public GameObject pausemenu;
   public bool paused;

   private int p1score;
   private int p2score;


   void Start(){
      p1score = 0;
      p2score = 0;
      paused = false;
      pausemenu.SetActive(false);
   }
   void Update(){
      if(Input.GetKey(KeyCode.Escape)){
         Application.Quit();
      }
      if(Input.GetKeyDown(KeyCode.Space)){
         TogglePause();
      }
   }
   public void P1Scored(){
      p1display.GetComponent<TextMeshProUGUI>().text = (++p1score).ToString();
      GameReset();
   }
   public void P2Scored(){
      p2display.GetComponent<TextMeshProUGUI>().text = (++p2score).ToString();
      GameReset();
   }
   private void GameReset(){
      ball.GetComponent<Ball>().Reset();
      p1paddle.GetComponent<Paddle>().Reset();
      p2paddle.GetComponent<Paddle>().Reset();
   }

   public void TogglePause(){
      if(paused){
         ball.GetComponent<Ball>().Unpause();
         pausemenu.SetActive(false);
         paused = false;
      }else{
         ball.GetComponent<Ball>().Pause();
         pausemenu.SetActive(true);
         paused = true;
      }
   }
}
