using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientGeneration : Generator {

    [SerializeField] List <GameObject> jacket;
    [SerializeField] List <GameObject> hair;
    [SerializeField] List <GameObject> skin;
    [SerializeField] List <GameObject> pants;
    [SerializeField] List <Transform> SpawnPoint;

    private GameObject spawnObject_jacket;
    private GameObject spawnObject_hair;
    private GameObject spawnObject_skinColor;
    private GameObject spawnObject_pants;


	// Use this for initialization
    void OnEnable () {
        //int RandomJacket;
        //int RandomHair;
        //RandomJacket = Random.Range(0, jacket.Count - 1);
        //RandomHair = Random.Range(0, hair.Count - 1);

        GenerationProcedure(jacket);



        SpawnClient();
        print(SpawnPoint.Count);
    }

    void SpawnClient () {
        for (int i = 0; i < 1; i++)
        {
            spawnObject_jacket = Instantiate(jacket[Random.Range(0, jacket.Count)], 
                SpawnPoint[0].position, SpawnPoint[0].rotation);
            spawnObject_hair = Instantiate(hair[Random.Range(0, hair.Count)], 
                SpawnPoint[1].position, SpawnPoint[1].rotation);
/*            spawnObject_skinColor = Instantiate(skin[Random.Range(0, skin.Count)], 
                SpawnPoint[2].position, SpawnPoint[2].rotation);
            spawnObject_pants = Instantiate(pants[Random.Range(0, pants.Count)], 
                SpawnPoint[3].position, SpawnPoint[3].rotation);*/
        }
    }


    void OnDisable (){
            Destroy(spawnObject_jacket);
            Destroy(spawnObject_hair);
//          Destroy(spawnObject_skinColor);
//          Destroy(spawnObject_pants);

    }
}
