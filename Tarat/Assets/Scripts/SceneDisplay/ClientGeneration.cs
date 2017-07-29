using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientGeneration : Generator {

    public RepAndCash RepData;

    [SerializeField] List <GameObject> jacket;
    [SerializeField] List <GameObject> hair;
    [SerializeField] List <GameObject> skin;
    [SerializeField] List <GameObject> pants;
    [SerializeField] List <Transform> SpawnPoint;
    [SerializeField] List <int> SocialStatus;

    private GameObject spawnObject_jacket;
    private GameObject spawnObject_hair;
    private GameObject spawnObject_skinColor;
    private GameObject spawnObject_pants;

    public int socialStatus;

	// Use this for initialization
    void OnEnable ()
    {
        GenerationProcedure(jacket);

        SpawnClient();
    }

    void SpawnClient () {
        for (int i = 0; i < 1; i++)
        {
            // Check if Rep exceeds 70 AFTER scoring
            if (RepData.ReputationPoints < RepData.RepBorderLow)
            {
                socialStatus = SocialStatus[Random.Range(1, SocialStatus.Count)];
                print(socialStatus + "This is Rep");
            }
            // Check if Rep is less than 30 AFTER scoring
            else if (RepData.ReputationPoints > RepData.RepBorderHigh)
            {
                socialStatus = SocialStatus[Random.Range(0, SocialStatus.Count - 1)];
                print(socialStatus + "This is Rep");
            }
            // for all other cases between 70 > x < 30.
            else
            {
                socialStatus = SocialStatus[Random.Range(0, SocialStatus.Count)];
                print(socialStatus + "This is Rep");
            }

            spawnObject_jacket = Instantiate(jacket[Random.Range(0, jacket.Count)], 
                SpawnPoint[0].position, SpawnPoint[0].rotation);
            spawnObject_hair = Instantiate(hair[Random.Range(0, hair.Count)], 
                SpawnPoint[1].position, SpawnPoint[1].rotation);
        }
    }

    void OnDisable (){
            Destroy(spawnObject_jacket);
            Destroy(spawnObject_hair);

        socialStatus = 0;
    }
}
