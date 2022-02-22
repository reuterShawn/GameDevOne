using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PongManager : MonoBehaviour
{  

    [SerializeField] private TMP_Text rightText;
    [SerializeField] private TMP_Text leftText;
    private int rightCount = 0;
    private int leftCount = 0;

   private void Awake() {
       LeftPongGoal.onScore += HandleP1Score;
       RightPongGoal.onScore += HandleP2Score;
       // PongBall.Restart();
   }

   void HandleP2Score(){
       Debug.Log("Right goal post hit");
       rightCount++;
       rightText.text = "" + rightCount;
   }

    void HandleP1Score() {
       Debug.Log("Left goal post hit");
       leftCount++;
       leftText.text = "" + leftCount;
   }
}
