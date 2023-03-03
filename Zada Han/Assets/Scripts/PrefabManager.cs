using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabManager : MonoBehaviour
{

    public float timer;
    private float timerStartCount;


    public GameObject[] prefabs;
    public Transform[] prefabLocations;

    public int currentFab;

    void Start()
    {
        timerStartCount = timer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
    }


    private void FixedUpdate()
    {
        if (timer <= 0)
        {
            deployPrefab();
            timer = timerStartCount;
        }

        if (currentFab >= prefabs.Length - 1)
        {
            currentFab = -1;
        }
    }


    void deployPrefab()
    {
        Instantiate(prefabs[currentFab + 1], prefabLocations[Random.RandomRange(0, prefabLocations.Length)].position, Quaternion.identity);
        currentFab = currentFab + 1;

    }
}
