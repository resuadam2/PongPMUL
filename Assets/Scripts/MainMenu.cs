using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
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
