using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RepAndCash : MonoBehaviour {

    public ClientGeneration clientGeneration;

    [SerializeField] Text RepScore;
    [SerializeField] Text CashScore;

    //Computer tools to keep track of current values for cash and rep
    public int myCash;
	public int myRep;

    //Fixed numbers that the player will see appear when it's time to witness
    // scores
	public  int ReputationPoints;
	public  int CashPoints;

/*    //Outcome of the answer: True or False
    public bool StatusAnswer;*/

    public int RepBorderHigh = 70;
    public int RepBorderLow = 30;

    // FOR USE DURING LETTER SCENE
    public void UpdateScores () {
        RepScore.text = ReputationPoints.ToString();
        CashScore.text = CashPoints.ToString();

        //Add Delay
        print("short delay");

        CashPoints += myCash;
        ReputationPoints += myRep;

        // Add Animation or whatevs
	}


	// FOR USE DURING EVERY BACKGROUND SCENE AFTER ANSWER IS GIVEN
    public void PointGeneration (bool isCorrect) {
        if(clientGeneration.socialStatus == 1){
            myCash += 15;
            if (isCorrect == true){
				myRep += 15;
			} else {
				myRep -= 15;
			}
		}
        else if (clientGeneration.socialStatus == 2) {
			myCash += 10;
            if (isCorrect == true){
				myRep += 10;
			} else {
				myRep -= 10;
			}
		}
        else if (clientGeneration.socialStatus == 3) {
			myCash += 5;
            if (isCorrect == true){
				myRep += 5;
			} else {
				myRep -= 5;
			}
		}
	}


}
