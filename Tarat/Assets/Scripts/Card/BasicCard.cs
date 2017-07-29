using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicCard : Card {

    [SerializeField]
    private Text story;   
    public List<Text> outcomes;
    public List<Text> hints;
    public List<Text> predictions;
    int randomint;
    
    
      
    // Use this for initialization
    void OnEnable ()
    {
        randomint = Random.Range(0, predictions.Count);
    
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
