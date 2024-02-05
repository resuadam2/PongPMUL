using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Update()
    {
        // If the player presses the escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Quit the game
            Debug.Log("Quitting game");
            Application.Quit();
        }
    }

    public void PlayerCPU()
    {
        // Load the CPU scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("PlayerCPU");
    }

    public void PVP()
    {
        // Load the PVP scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("PVP");
    }
}
