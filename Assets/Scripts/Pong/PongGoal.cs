using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PongGoal : MonoBehaviour
{

    public event Action onScore;

    [SerializeField] private Transform p1Goal;
    [SerializeField] private Transform p2Goal;
    // [SerializeField] private TMP_Text goalNumberText;
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Ball")) {
            onScore?.Invoke();
            Debug.Log("Something is happening");

        }
    }

}
