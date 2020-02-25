using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void LoadLevel(string loadName)
    {
        switch(loadName)
        {
            case "Main Menu Scene":
                SceneManager.LoadScene(0);
                break;
            case "Game Scene":
                SceneManager.LoadScene(1);
                break;
            case "Game Over Scene":
                SceneManager.LoadScene(2);
                break;
            case "Instructions Scene":
                SceneManager.LoadScene(3);
                break;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
