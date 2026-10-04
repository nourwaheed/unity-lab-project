using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
 public float moveSpeed;
 public float jumpHeight;
 public KeyCode spacebar;
 public KeyCode L;
 public KeyCode R;
 public Transform groundCheck;
 public float groundCheckRadius;
 public LayerMask WhatIsGround;
 private bool isGrounded;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
      if(Input.GetKeyDown(spacebar)&& isGrounded)
        {
          Jump();  
        }
        if(Input.GetKey(L))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
       if(GetComponent<SpriteRenderer>()!= null)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        }
        if(Input.GetKey(R))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            if(GetComponent<SpriteRenderer>()!= null)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
        }
void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }



    }
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, WhatIsGround);
    }
}
