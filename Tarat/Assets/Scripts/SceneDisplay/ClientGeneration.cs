using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientGeneration : Generator {

    public RepAndCash RepData;

    [SerializeField] List <GameObject> Character;
    [SerializeField] List <Transform> SpawnPoint;
    [SerializeField] List <int> SocialStatus;
    [SerializeField] List <string> CharNames;

    private GameObject spawnObject_Character;


    public int socialStatus;

    private string characterName;
    private int genderMale;



	// Use this for initialization
    void OnEnable ()
    {
        GenerationProcedure(Character);

        SpawnClient();
    }

    void SpawnClient () {
        for (int i = 0; i < 1; i++)
        {
            // Check if Rep less or equal than lower border
            if (RepData.ReputationPoints <= RepData.RepBorderLow)
            {
                socialStatus = SocialStatus[2]/*[Random.Range(1, SocialStatus.Count)]*/;
                print(socialStatus + "This is Rep");
            }
            // Check if Rep is more or equal than high border
            else if (RepData.ReputationPoints >= RepData.RepBorderHigh)
            {
                socialStatus = SocialStatus[0]/*[Random.Range(0, SocialStatus.Count - 1)]*/;
                print(socialStatus + "This is Rep");
            }
            // for all other cases between 70 > x < 30.
            else
            {
                socialStatus = SocialStatus[1]/*[Random.Range(0, SocialStatus.Count)]*/;
                print(socialStatus + "This is Rep");
            }

            genderMale = Random.Range(0, 2);
            print(genderMale);

            if(genderMale == 1.0f)
            {
                characterName = CharNames[Random.Range(0, 6)];
                spawnObject_Character = Instantiate(Character[Random.Range(0, 2)], 
                    SpawnPoint[0].position, SpawnPoint[0].rotation);
            }
            else
            {
                characterName = CharNames[Random.Range(6, 11)];
                spawnObject_Character = Instantiate(Character[Random.Range(2, 4)], 
                    SpawnPoint[0].position, SpawnPoint[0].rotation);
            }

            print(characterName + " is a human " + genderMale + " (1 being male" +
                ", 0 being female)");

        }
    }

    void OnDisable (){
        Destroy(spawnObject_Character);

        characterName = "";
        socialStatus = 0;
    }
}
