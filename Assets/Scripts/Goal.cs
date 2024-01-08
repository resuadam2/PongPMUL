using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal; // This is set in the inspector

    // This method is called when the ball enters the goal area (the trigger collider)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (isPlayer1Goal)
            {
                // FindObjectOfType<GameManager>() is a reference to the GameManager script in the scene (there should only be one)
                FindObjectOfType<GameManager>().GoalScored(2); // 2 is the player number
            }
            else
            {
                FindObjectOfType<GameManager>().GoalScored(1); // 1 is the player number
            }
        }
    }
}
