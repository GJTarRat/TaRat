using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepAndCash : MonoBehaviour {

    public ClientGeneration clientGeneration;

    //Computer tools to keep track of current values for cash and rep
    public static int myCash;
	public static int myRep;

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
		myCash += CashPoints;
		myRep += ReputationPoints;
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
