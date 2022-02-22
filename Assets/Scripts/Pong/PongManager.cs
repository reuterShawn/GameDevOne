using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PongManager : MonoBehaviour
{  

    [SerializeField] private TMP_Text rightText;
    [SerializeField] private TMP_Text leftText;
    
    private int rightScore = 0;
    private int leftScore = 0;
    private int winningScore = 3;

   private void Awake() {
       LeftPongGoal.onScore += HandleP1Score;
       RightPongGoal.onScore += HandleP2Score;
       PongBall.Restart();
   }

   void HandleP2Score(){
       
       rightScore++;
       if (rightScore == winningScore){
           StartCoroutine(youWin(true));
       }
       rightText.text = "" + rightScore;
       ball.Restart;
   }

    void HandleP1Score() { 
       leftScore++;
       if (leftScore == winningScore){
           StartCoroutine(youWin(true));
       }
       leftText.text = "" + leftScore;
       ball.Restart;
   }
}
