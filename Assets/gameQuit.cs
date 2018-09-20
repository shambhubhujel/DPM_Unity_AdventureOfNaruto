using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameQuit : MonoBehaviour {

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void BackMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
