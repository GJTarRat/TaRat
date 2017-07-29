using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Generator : MonoBehaviour {

    protected List <GameObject> RandGO;

	
	// Update is called once per frame
    protected virtual void GenerationProcedure (List<GameObject> GameObjects) {
        int RandInt;
        RandInt = Random.Range(0, GameObjects.Count);

        print(RandInt);
	}
}
