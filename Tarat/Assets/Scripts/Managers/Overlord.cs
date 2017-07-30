using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overlord : Singleton<Overlord> {

    Overlord() { }

    enum GameState { generateCards, feedbackLetter }

    public LogicGenerator logicGenerator;
    public ClientGeneration clientGeneration;

    public static int clientsCounter =0;

    public bool isNextClient = false;

    public int answer;

	// Use this for initialization
	void Start ()
    {
        //logicGenerator.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (clientsCounter <= 3)
            isNextClient = false;
        else
            isNextClient = true;           
        
        InputManager();

        if (isNextClient)
            Reshuffle();
    }

    void InputManager()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            answer = 0;
            CompareAnswers();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            answer = 1;
            CompareAnswers();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            answer = 2;
            CompareAnswers();
        }
    }

    public void Reshuffle()
    {
        print("Reshuffle");

        UIManager.Instance.cardSpriteHolder.sprite = null;
        isNextClient = false;

        GenerateClient();
    }

    public void GenerateCard()
    {
        logicGenerator.GenerateCard();
        print("gene");
    }

    void GenerateClient()
    {
        clientGeneration.gameObject.SetActive(false);
        clientGeneration.gameObject.SetActive(true);
    }

    void CompareAnswers()
    {       

        if (!isNextClient)
            GenerateCard();

        clientsCounter++;
        print(clientsCounter);
        //if (answer == logicGenerator.chosenCard.randomint)
        // print("correct");
        //else        
        //print("wrong");

        //GenerateCard();       

    }



   
}
