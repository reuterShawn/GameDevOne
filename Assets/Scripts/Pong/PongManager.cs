using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PongManager : MonoBehaviour
{  
    [SerializeField] private float HandleP1Score;
    [SerializeField] private float HandleP2Score;

   private void Awake() {
    //    p1Goal.onScore += HandleP2Score;
    //    p2Goal.onScore += HandleP1Score;
    //    PongBall.Restart();
   }
}
