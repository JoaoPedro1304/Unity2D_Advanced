using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMove : MonoBehaviour
{
    public Transform knight;    
    public Animator animator;
    public LayerMask ground;
    Rigidbody2D rb;
    Vector2 direction;
    float speed = 2f;    
    float jumpForce = 5f;
    float delayTimeAttack = 0.3f; 
    float lastTimeAttack =0;   
    void Start()
    {
        animator = GetComponent<Animator>();

        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
        direction = new Vector2(Input.GetAxis("Horizontal"),0);

        //attack
        if(Input.GetKeyDown(KeyCode.Mouse0) && Time.time > lastTimeAttack + delayTimeAttack)
        {
            lastTimeAttack = Time.time;
            
            animator.SetTrigger("attack");
        }

        //move
        if(Input.GetKey("a"))
        {            
            Move(knight,direction);
            animator.SetInteger("move",1);
            transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
            
        }
        else if (Input.GetKey("d"))
        {            
            Move(knight,-direction);
            animator.SetInteger("move",1);
            transform.rotation = Quaternion.Euler(new Vector3(0,-180,0));
            
        }else{
            animator.SetInteger("move",0);
        }
        
        //jump
        if(Input.GetKeyDown("space") && IsGrounded())
        {
            rb.AddForce(Vector2.up * jumpForce , ForceMode2D.Impulse);            
        }        

       
    }
    //move method
    void Move(Transform t, Vector2 direction)
    {
        t.Translate(direction * speed * Time.deltaTime);
    }

    //check if player is grounded
    bool IsGrounded()
    {
        if(Physics2D.Raycast(transform.position, Vector2.down,1.5f ,ground))
        
            return true;

        else
        
            return false;        
        
    }

    }

