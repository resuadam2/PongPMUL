using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball, player1, player2, goal1, goal2; // These are set in the inspector
    public int player1Score, player2Score; // These are set in the inspector
    public TMPro.TextMeshProUGUI player1ScoreText, player2ScoreText; // These are set in the inspector

    // This method is called when the ball enters the goal area (the trigger collider)
    public void GoalScored(int playerNumber)
    {
        if (playerNumber == 1)
        {
            player1Score++;
            player1ScoreText.text = player1Score.ToString();
        }
        else if (playerNumber == 2)
        {
            player2Score++;
            player2ScoreText.text = player2Score.ToString();
        }
        ReserPositions();
    }

    // This method is called to reset the ball and players to their starting positions
    private void ReserPositions()
    {
        ball.GetComponent<Ball>().Reset();
        player1.GetComponent<Players>().Reset();
        player2.GetComponent<Players>().Reset();
    }

}
