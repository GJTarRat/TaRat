using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckOnClick : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Overlord.Instance.GenerateCard();
            Overlord.clientsCounter = 1;

        }
    }
}
