using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientGeneration : Generator {

    [SerializeField]
    List <GameObject> jacket;
    [SerializeField] 
    List <GameObject> hair;





	// Use this for initialization
    void OnEnable () {
        //int RandomJacket;
        //int RandomHair;
        //RandomJacket = Random.Range(0, jacket.Count - 1);
        //RandomHair = Random.Range(0, hair.Count - 1);

        GenerationProcedure(jacket);
        GenerationProcedure(hair);

    }
}
