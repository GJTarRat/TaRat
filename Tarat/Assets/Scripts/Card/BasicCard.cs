using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BasicCard : Card {

    [SerializeField]
    private Text story;   
    public List<Text> outcomes;
    public List<Text> hints;
    public List<Text> predictions;
    public int randomint;
    public SpriteRenderer cardSprite;
    public Text chosenPrediction;
    public Text chosenHint;
    public Text chosenOutcome;

    public delegate void cardlogicDelegate();

    // Use this for initialization
    void OnEnable ()
    {
       
    }

	// Update is called once per frame
	void Update ()
    {
		
	}

    public void cardlogic ()
    {
        randomint = UnityEngine.Random.Range(0, predictions.Count);
        chosenPrediction = predictions[randomint];
        chosenHint = hints[randomint];
        chosenOutcome = outcomes[randomint];
    }

}
