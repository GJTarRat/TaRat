using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DisplayOnClick : MonoBehaviour, IPointerDownHandler {

    public bool isDisplayed;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (isDisplayed)
            gameObject.SetActive(true);
        else
            gameObject.SetActive(false);
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
