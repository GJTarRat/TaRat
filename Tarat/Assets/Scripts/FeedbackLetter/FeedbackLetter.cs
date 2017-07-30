using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackLetter : MonoBehaviour {

    public RepAndCash repAndCash;
    public ClientGeneration clientGeneration;

    public List<Text> outcomeHolders;
    public List<Text> repChange;
    public Text accumulatedRep;
    public Text accumulatedCash;
   

    void OnEnable()
    {
        accumulatedCash.text = repAndCash.CashPoints.ToString();
        accumulatedRep.text = repAndCash.ReputationPoints.ToString();

        DescribeOutcomes();

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void DescribeOutcomes()
    {
        int i = 0;
        foreach (var item in outcomeHolders)
        {
            item.text = Overlord.Instance.chosenSet[i].chosenOutcome.text;
            i++;
        }
    }

    void DescribeReputation()
    {
        int i = 0;

        foreach (var item in repChange)
        {

        }
    }
}
