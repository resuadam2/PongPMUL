using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ball, player1, player2, goal1, goal2; // These are set in the inspector
    public int player1Score, player2Score; // These are set in the inspector
    public TMPro.TextMeshProUGUI player1ScoreText, player2ScoreText; // These are set in the inspector

    public bool pvp; 

    public int maxScore = 5; // This is set in the inspector

    private string winner; // This is used to store the winner of the game

    private static GameManager _instance; // This is used to make sure there is only one GameManager in the scene


    // This method is called when the game starts and is used to make sure there is only one GameManager in the scene
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this; // This makes sure the GameManager is not destroyed when a new scene is loaded
            DontDestroyOnLoad(gameObject); // This makes sure the GameManager is not destroyed when a new scene is loaded
        }
        else
        {
            Destroy(gameObject);    // This destroys the GameManager if there is already one in the scene
        }
    }

    // This method is called when the ball enters the goal area (the trigger collider)
    public void GoalScored(int playerNumber)
    {
        if (playerNumber == 1)
        {
            player1Score++;
            player1ScoreText.text = player1Score.ToString();
            checkWin();
        }
        else if (playerNumber == 2)
        {
            player2Score++;
            player2ScoreText.text = player2Score.ToString();
            checkWin();
        }
        ReserPositions();
    }

    // This method is called to reset the ball and players to their starting positions
    private void ReserPositions()
    {
        ball.GetComponent<Ball>().Reset();
        player1.GetComponent<Players>().Reset();
        if (pvp)
        {
            player2.GetComponent<Players>().Reset();
        }
    }

    public void checkWin()
    {
        if (player1Score >= maxScore)
        {
            Debug.Log("Player 1 wins!");
            winner = "Player 1";
            SceneManager.LoadScene("Winner");
        }
        else if (player2Score >= maxScore && pvp)
        {
            Debug.Log("Player 2 wins!");
            winner = "Player 2";
            SceneManager.LoadScene("Winner");
        }
        else if (player2Score >= maxScore && !pvp)
        {
            Debug.Log("AI wins!");
            winner = "CPU";
            SceneManager.LoadScene("Winner");
        }
    }

    public string getWinner()
    {
        return winner;
    }
}
