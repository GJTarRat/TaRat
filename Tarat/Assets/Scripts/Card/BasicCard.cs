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
    public Text chosenPrediction;
    public Text chosenHint;
    public Text chosenOutcome;

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
        randomint = Random.Range(0, predictions.Count);
        chosenPrediction = predictions[randomint];
        chosenHint = hints[randomint];
        chosenOutcome = outcomes[randomint];
    }

}
