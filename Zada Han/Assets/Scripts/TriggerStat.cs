using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStat : MonoBehaviour
{
    public SkillsTimeProgress stats;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Rock")&&other.gameObject.GetComponent<MeshFilter>().mesh!=null)
        {
            stats.time = stats.time - 5;
            other.gameObject.GetComponent<BoxCollider>().enabled= false;
        }
        if (other.gameObject.CompareTag("Stone"))
        {
            stats.time=stats.time +3;
        }
    }
}
