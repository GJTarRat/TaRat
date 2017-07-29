using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour {

    public int TT_choiceMade = 0;

    // This is instantiated when the player must select an option.
    void SelectOption () {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            TT_choiceMade = 1;
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            TT_choiceMade = 2;
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
           TT_choiceMade = 3;
        }
    }
}
