using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{

   public ParticleSystem thunder;

    public AudioClip[] ThunderClips;
   public float timer;
    public float nextThunder;
    public AudioSource thunderSource;

    public bool ThunderSend;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            thunder.Play();
        }

        if (timer > nextThunder)
        {
           ThunderSend = true;



        }

        if (ThunderSend)
        {
            thunderSource.clip = ThunderClips[Random.Range(0,ThunderClips.Length)];

            thunderSource.Play();
            thunder.Play();
            timer = 0;
            nextThunder = Random.RandomRange(12f,24f);
            ThunderSend = false;
        }
    }

}
