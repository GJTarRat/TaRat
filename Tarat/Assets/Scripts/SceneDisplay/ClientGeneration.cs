using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientGeneration : Generator {

    [SerializeField]
    List <GameObject> jacket;
    [SerializeField] 
    List <GameObject> hair;


    public Transform SpawnPoint_jacket;
    public Transform SpawnPoint_hair;

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

    }

    void SpawnClient () {
        spawnObject_jacket = Instantiate(jacket[Random.Range(0, jacket.Count)], 
            SpawnPoint_jacket.position, SpawnPoint_jacket.rotation);

        spawnObject_hair = Instantiate(hair[Random.Range(0, hair.Count)], 
            SpawnPoint_hair.position, SpawnPoint_hair.rotation);
    }

    void OnDisable (){
        Destroy(spawnObject_jacket);
        Destroy(spawnObject_hair);
    }
}
