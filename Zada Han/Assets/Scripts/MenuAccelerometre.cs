using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuAccelerometre : MonoBehaviour
{

    private Rigidbody rb;
    public float dirX;
    public float moveSpeed;


    public bool moving;
    Animator animator;

    public int total;

    bool nextScene;

    public GameObject oldSceneObjects;
    public GameObject NextSceneObjects;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        dirX = Input.acceleration.x * moveSpeed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);


        if (dirX <1&&dirX>-1)
        {
          moving = false;

        }
        else
        {
            moving=true;
        }

       if (!moving)
        {
            total = 0;

        }

       

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, 0f);

   
        
        if (total > 3)
        {
            nextScene = true;
        }


        if (nextScene)
        {

            NextSceneObjects.SetActive(true);
            oldSceneObjects.SetActive(false);

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (moving)
        {
            if (collision.gameObject.CompareTag("wall"))
            {
                total = total + 1;
            }
        }
       
      
    }
}
