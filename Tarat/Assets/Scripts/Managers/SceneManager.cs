using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : Singleton<SceneManager> {

    SceneManager() { }

    public Button startButton;


	// Use this for initialization
	void Start () {
        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
	
	// Update is called once per frame
	void TaskOnClick () {
        Debug.Log("you have clicked the button");
	}
}
