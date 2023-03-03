using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMovement : MonoBehaviour
{
    public Vector3 vec;
    public float speed;


    public float vecZ;
    void Start()
    {
        vec = gameObject.transform.position;
        vecZ = gameObject.transform.position.z;


        Destroy(gameObject,12f);

    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.position = vec;

        vec = transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, vecZ);

        vecZ -= Time.deltaTime * speed;

    }
}
