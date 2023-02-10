using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometre : MonoBehaviour
{

    private Rigidbody rb;
   public float dirX;
  public  float moveSpeed;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    void Update()
    {
     dirX=Input.acceleration.x*moveSpeed;
        transform.position=new Vector2(Mathf.Clamp(transform.position.x,-7.5f,7.5f),transform.position.y);
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, 0f);
    }
}
