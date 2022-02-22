using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LeftPongGoal: MonoBehaviour
{

    public static event Action onScore;

    // [SerializeField] private TMP_Text goalNumberText;
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Ball")) {
            onScore?.Invoke();
            Debug.Log("Something is happening");
        }
    }

}
