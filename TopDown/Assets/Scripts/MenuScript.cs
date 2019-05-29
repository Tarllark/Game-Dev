using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{

    private string game = "CircleOfLife";

    public void startGame()
    {
        SceneManager.LoadScene(game);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
