using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class UIManager : Singleton<UIManager>{

    protected UIManager() { }

    Card card;
    
    public Text hint;
    public List<Text> predictions;
    public SpriteRenderer cardSpriteHolder;
    public Text outcome;
    public GameObject feedLetter;

    // Use this for initialization
    void Start ()
    {
        feedLetter.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
