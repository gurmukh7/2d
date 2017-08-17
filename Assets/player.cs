using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public float topSpeed = 10f;

    bool facingRight = true;

    Animator anim;

    bool grounded = false;

    public Transform GameObject;

    float groundRadius = 0.2f;

    public float jumpForce = 200f;
    
    public LayerMask whatIsGround;

    void Start()
    { 

      anim = GetComponent<Animator>();

    }

    void Update()
    {
        //Movement...


        anim.SetBool("Run", true);

        bool GameObject = false;

        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Ground", false);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }
    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(GameObject.position, groundRadius, whatIsGround);
        anim.SetBool("Ground", grounded);

        anim.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);
        float move = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody2D>().velocity = new Vector2(move * topSpeed, GetComponent<Rigidbody2D>().velocity.y);

        anim.SetFloat("Speed", Mathf.Abs(move));
        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }

    void Flip()
    { 
        facingRight = !facingRight;
       
      Vector3 theScale = transform.localScale;
       theScale.x *= -1;
        }
}
