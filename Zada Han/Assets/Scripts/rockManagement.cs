using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockManagement : MonoBehaviour
{

    public GameObject particles;
    public GameObject colliderInner;
    void Start()
    {
        particles.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<BoxCollider>().isTrigger= true;
            gameObject.GetComponent<MeshFilter>().mesh= null;
            gameObject.GetComponent<AudioSource>().Play();
            particles.SetActive(true);

            Destroy(gameObject,4f);
        }


        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Skill1"))
        {

            gameObject.GetComponent<BoxCollider>().isTrigger = true;
            gameObject.GetComponent<BoxCollider>().enabled = false;

            gameObject.GetComponent<MeshFilter>().mesh = null;
            gameObject.GetComponent<AudioSource>().Play();
            particles.SetActive(true);


            Destroy(gameObject, 4f);

            Debug.Log(gameObject.name + " Skill 1 " + "'e" + " maruz kaldý.");
        }

        
    }
}
