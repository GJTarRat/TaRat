using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepAndCash : MonoBehaviour {

	public static int myCash;
	public static int myRep;

	public  int ReputationPoints;
	public  int CashPoints;

	public bool StatusRich;
	public bool StatusNorm;
	public bool StatusPoor;

	public bool StatusAnswer;

	public void UpdateScores () {
		myCash += CashPoints;
		myRep += ReputationPoints;
	}

	// Update is called once per frame
	public void PointsGain () {


		if(StatusRich){
			myCash += 15;
			if (StatusAnswer == true){
				myRep += 15;
			} else {
				myRep -= 15;
			}
		}
		else if (StatusNorm) {
			myCash += 10;
			if (StatusAnswer == true){
				myRep += 10;
			} else {
				myRep -= 10;
			}
		}
		else if (StatusPoor) {
			myCash += 5;
			if (StatusAnswer == true){
				myRep += 5;
			} else {
				myRep -= 5;
			}
		}
	}
}
