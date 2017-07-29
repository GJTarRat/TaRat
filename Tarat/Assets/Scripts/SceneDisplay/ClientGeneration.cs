using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientGeneration : Generator {

    [SerializeField] List <GameObject> jacket;
    [SerializeField] List <GameObject> hair;
    [SerializeField] List <Transform> SpawnPoint;

    private GameObject spawnObject_jacket;
    private GameObject spawnObject_hair;

	// Use this for initialization
    void OnEnable () {
        //int RandomJacket;
        //int RandomHair;
        //RandomJacket = Random.Range(0, jacket.Count - 1);
        //RandomHair = Random.Range(0, hair.Count - 1);

        GenerationProcedure(jacket);
        GenerationProcedure(hair);


        SpawnClient();
        print(SpawnPoint.Count);
    }

    void SpawnClient () {
        for (int i = 0; i < SpawnPoint.Count; i++)
        {
            spawnObject_jacket = Instantiate(jacket[Random.Range(0, jacket.Count)], 
                SpawnPoint[i].position, SpawnPoint[i].rotation);
        }
    }


    void OnDisable (){
        Destroy(spawnObject_jacket);
        Destroy(spawnObject_hair);
    }
}
