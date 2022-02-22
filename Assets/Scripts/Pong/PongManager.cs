using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PongManager : MonoBehaviour
{  

   private void Awake() {
       LeftPongGoal.onScore += HandleP1Score;
       RightPongGoal.onScore += HandleP2Score;
       // PongBall.Restart();
   }

   void HandleP2Score(){
       Debug.Log("Right goal post hit");
   }

    void HandleP1Score() {
       Debug.Log("Left goal post hit");
   }
}
