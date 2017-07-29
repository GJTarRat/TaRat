using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;


public class LogicGenerator : Generator {

    [SerializeField]
    List<BasicCard> cardSet;
    public BasicCard chosenCard;

    //public static int clientCounter;

    public Action BasicCardEvent;

    private void OnEnable()
    {
        //if (cardSet.Count < 1)
        //{
        //    //cardSet.Clear();
        //    cardSet.AddRange(GetComponentsInChildren<BasicCard>(true));
        //}

        //int randomInt = UnityEngine.Random.Range(0, cardSet.Count);
        //chosenCard = cardSet[randomInt];
        //cardSet.Remove(chosenCard);
        //chosenCard.gameObject.SetActive(true);

        //SetText();
        //SetCardSprite();      
    }

    public void GenerateCard()
    {
        if (cardSet.Count < 1)
        {
            cardSet.AddRange(GetComponentsInChildren<BasicCard>(true));
        }

        int randomInt = UnityEngine.Random.Range(0, cardSet.Count);
        chosenCard = cardSet[randomInt];
        cardSet.Remove(chosenCard);
        chosenCard.gameObject.SetActive(true);

        SetText();
        SetCardSprite();
    }

    void SetText()
    {
        int counter = 0;

        chosenCard.cardlogic();
        UIManager.Instance.hint.text = chosenCard.chosenHint.text;

        for (int i = 0; i < UIManager.Instance.predictions.Count; i++)
        {
            UIManager.Instance.predictions[i].text = i+1 + ". " + chosenCard.predictions[i].text;
        }
    }

    void SetCardSprite()
    {
       // print(Overlord.clientsCounter);
     
        UIManager.Instance.cardHolders[0].sprite = chosenCard.cardSprite.sprite;


        //foreach (var item in UIManager.Instance.cardHolders)
        //{
        //    item.sprite = null;
        //    Overlord.clientsCounter = 0;
        //}
    }


    void DisplayCard(int carndNum)
    {
        chosenCard.gameObject.SetActive(true);
    }


}
