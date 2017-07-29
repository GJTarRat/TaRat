using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : Singleton<SceneManager> {

    SceneManager() { }
	
	// Update is called once per frame
    public void LoadMainLevel (string mainScene) {
        Application.LoadLevel(mainScene);
	}

    public void ExitGame (){
        Application.Quit();
        print("The game has quit");
    }
}
