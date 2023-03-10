using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabManager : MonoBehaviour
{

    public float StoneTimer;
    public float RockTimer;

    private float StonetimerStartCount;
    private float RocktimerStartCount;



    public GameObject[] StonesPrefabs;
    public Transform[] StonesPrefabLocations;

    public GameObject[] RockPrefabs;
    public Transform[] RockPrefabLocations;

    public int StoneCurrentFab;
    public int RockCurrentFab;

    public SkillsTimeProgress progress;

    public bool[] zorluk;
    void Start()
    {
        StonetimerStartCount = StoneTimer;
        RocktimerStartCount = RockTimer;

    }

    // Update is called once per frame
    void Update()
    {
        StoneTimer -= Time.deltaTime;
        RockTimer-= Time.deltaTime;
    }


    private void FixedUpdate()
    {
        if (progress.time > 60 && zorluk[0]==false)
        {
            RocktimerStartCount = RocktimerStartCount - 0.55f;
            Debug.Log(RocktimerStartCount);

            zorluk[0] = true;
        }
        if (progress.time > 70 && zorluk[1] == false)
        {
            RocktimerStartCount = RocktimerStartCount - 0.55f;


            Debug.Log(RocktimerStartCount);

            zorluk[1] = true;

        }
        if (progress.time > 80 && zorluk[2] == false)
        {
            RocktimerStartCount = RocktimerStartCount - 0.55f;


            Debug.Log(RocktimerStartCount);
            zorluk[2] = true;

        }
        if (progress.time > 90 && zorluk[3] == false)
        {
            RocktimerStartCount = RocktimerStartCount - 0.55f;


            Debug.Log(RocktimerStartCount);

            zorluk[3] = true;


        }
        if (StoneTimer <= 0)
        {
            deployPrefab();
            StoneTimer = StonetimerStartCount;
        }

        if (RockTimer <= 0)
        {
            deployRock();
            RockTimer = RocktimerStartCount;
        }

        if (StoneCurrentFab >= StonesPrefabs.Length - 1)
        {
            StoneCurrentFab = -1;
        }


        if (RockCurrentFab >= RockPrefabs.Length - 1)
        {
            RockCurrentFab = -1;
        }
    }


    void deployPrefab()
    {
        Instantiate(StonesPrefabs[StoneCurrentFab + 1], StonesPrefabLocations[Random.RandomRange(0, StonesPrefabLocations.Length)].position, Quaternion.identity);
        StoneCurrentFab = StoneCurrentFab + 1;    

    }

    void deployRock()
    {
        Instantiate(RockPrefabs[RockCurrentFab + 1], RockPrefabLocations[Random.RandomRange(0, RockPrefabLocations.Length)].position, Quaternion.identity);
        RockCurrentFab = RockCurrentFab + 1;
    }
}
