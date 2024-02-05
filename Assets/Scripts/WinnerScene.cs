using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinnerScene : MonoBehaviour
{
    private GameManager gameManager; // This is used to store the GameManager
    public TMPro.TextMeshProUGUI winnerText; // This is used to store the winner text and is set in the inspector

    // This method is called when the game starts
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();// This gets the GameManager
        winnerText.text = gameManager.GetComponent<GameManager>().getWinner() + " wins!"; // This gets the winner text from the GameManager
    }

    public void LoadMainMenu()
    {
        Destroy(gameManager.gameObject); // This destroys the GameManager (so that it can be re-created when the game is restarted
        SceneManager.LoadScene("MainMenu"); // This loads the MainMenu scene
    }
}
