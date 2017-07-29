using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {


    public void exitGame ()
    {
        Application.Quit();
        print("Game has Quit");
    }

	// Use this for StartGame
    public void startGame (string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
