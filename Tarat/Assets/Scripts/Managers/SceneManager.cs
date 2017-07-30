using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : Singleton<SceneManager> {

    SceneManager() { }
	
    [SerializeField] GameObject Scene1;
    [SerializeField] GameObject Scene2;
    [SerializeField] GameObject Scene3;
    [SerializeField] GameObject Scene4;


	// Update is called once per frame
/*    public void LoadMainLevel (string mainScene) {
        Application.LoadLevel(mainScene);
	}*/

    public void StartGame (string MainScene2){
        Application.LoadLevel(MainScene2);
    }

    public void RollCredits (string Credits) {
        Scene1.SetActive(true);
    }
     
    /*    public void MainMenu (string mainMenu) {
        Application.LoadLevel(mainMenu);
    } */

    public void InGameSwitch (string CurScene) {
        if (CurScene == "MainMenu")
        {
            Application.LoadLevel(CurScene);
        }
        else if (CurScene == "Quit")
        {
            Application.Quit();
            print("The Game has quit");
        }
        else if (CurScene == "Scene1")
        {
            Scene1.SetActive(true);
            Scene2.SetActive(false);
            Scene3.SetActive(false);
            Scene4.SetActive(false);
        }
        else if (CurScene == "Scene2")
        {
            Scene2.SetActive(true);
        }
        else if (CurScene == "Scene3")
        {
            Scene3.SetActive(true);
        }
        else if (CurScene == "Scene4")
        {
            Scene4.SetActive(true);
        }
    }
}
