using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometre : MonoBehaviour
{

    private Rigidbody rb;
   public float dirX;
  public  float moveSpeed;


    AudioSource MjolnirAudio;


    public AudioClip[] AbilitySoundEffects;

    bool right;
    bool left;

    Animator animator;


    void Start()
    {
        rb=GetComponent<Rigidbody>();
     animator=GetComponent<Animator>();
        MjolnirAudio=GetComponent<AudioSource>();

    }

    void Update()
    {
        animator.SetFloat("horizontalP",dirX);
     dirX=Input.acceleration.x*moveSpeed;
        transform.position=new Vector2(Mathf.Clamp(transform.position.x,-7.5f,7.5f),transform.position.y);


      if (Input.acceleration.x > 0)
        {
            Debug.Log("SAÐ"); 
            right=true;

        }

        if (Input.acceleration.x < 0)
        {
            Debug.Log("SOL");
            left=true;
        }
       

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, 0f);

    }

    public void SkillTornado()
    {

        MjolnirAudio.clip = AbilitySoundEffects[0];
        MjolnirAudio.Play();
    }

}
