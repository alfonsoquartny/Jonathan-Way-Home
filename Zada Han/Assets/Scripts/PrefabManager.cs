using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabManager : MonoBehaviour
{

    public float timer;
    private float timerStartCount;


    public GameObject[] prefabs;
    void Start()
    {
        timerStartCount = timer;
    }

    // Update is called once per frame
    void Update()
    {
        timer-= Time.deltaTime;
    }


    private void FixedUpdate()
    {
        if (timer <= 0)
        {
            deployPrefab();
            timer = timerStartCount;
        }
    }


    void deployPrefab()
    {
        Instantiate(prefabs[Random.Range(0,prefabs.Length)]);
    }
}
