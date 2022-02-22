using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class PongManager : MonoBehaviour
{

    [SerializeField] private TMP_Text rightText;
    [SerializeField] private TMP_Text leftText;

    private int rightScore = 0;
    private int leftScore = 0;
    private int winningScore = 3;


    private void Awake()
    {
        LeftPongGoal.onScore += HandleP1Score;
        RightPongGoal.onScore += HandleP2Score;
    }

    void OnDestroy()
    {
        LeftPongGoal.onScore -= HandleP1Score;
        RightPongGoal.onScore -= HandleP2Score;
    }

    private void HandleP2Score()
    {
        if (rightScore == winningScore)
        {
            StartCoroutine(rightWin("You won!"));
        }
        else
        {
            PongBall ball = gameObject.GetComponent<PongBall>();
            rightScore++;
            rightText.text = "" + rightScore;
            ball.Restart();
        }

    }

    private void HandleP1Score()
    {
        if (leftScore == winningScore)
        {
            StartCoroutine(leftWin("You won!"));
        }
        else
        {
            PongBall ball = gameObject.GetComponent<PongBall>();
            leftScore++;
            leftText.text = "" + leftScore;
            ball.Restart();
        }
    }

    IEnumerator leftWin(string message)
    {
        leftText.text = message;
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator rightWin(string message)
    {
        rightText.text = message;
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
