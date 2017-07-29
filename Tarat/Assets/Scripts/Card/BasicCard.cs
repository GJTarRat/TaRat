using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicCard : Card {

    [SerializeField]
    private Text story;
    //[SerializeField]
    //private Text outcome1;
    //[SerializeField]
    //private Text outcome2;
    //[SerializeField]
    //private Text outcome3;
    //[SerializeField]
    //private Text hint1;
    //[SerializeField]
    //private Text hint2;
    //[SerializeField]
    //private Text hint3;
    //[SerializeField]
    //private Text prediction1;
    //[SerializeField]
    //private Text prediction2;
    //[SerializeField]
    //private Text prediction3;

    
    public List<Text> outcomes;
    public List<Text> hints;
    public List<Text> predictions;
    int randomint;
    
    
      
    // Use this for initialization
    void OnEnable ()
    {
        randomint = Random.Range(1, 3);

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
