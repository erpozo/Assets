using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float jumpForce = 250f;
    public float rayLenght;
    private Rigidbody2D rb2D;
    public LayerMask floor;

    private void Awake(){
        rb2D = GetComponent<Rigidbody2D>();
    }


    void Start(){
        
    }
    // Update is called once per frame

    void Update()
    {
        Debug.DrawRay(transform.position, Vector2.down * rayLenght, Color.red);

        if (IsGrounded()){
            Jump(jumpForce);
        }
        Movement();
    }

    public void Movement()
    {
        float right = 10f;
        float left = -10f;
/*
        if (Input.GetKeyDown(KeyCode.A)){
            Move(left);
        }

        if (Input.GetKeyDown(KeyCode.D)){
            Move(right);
        }*/
        
        if (Input.GetKey(KeyCode.A)){
            Move(left);
        }

        if (Input.GetKey(KeyCode.D)){
            Move(right);
        }
    }

    public void Move(float force)
    {
        transform.Translate(force * Time.deltaTime, 0, 0);
    }

    public void Jump(float force)
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)){
            rb2D.AddForce(Vector2.up * force);
        }
    }

    public bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, rayLenght, floor);
        if (hit.collider != null)
        {
            Debug.Log("Has colisionado con el suelo");
            return true;
        }
        return false;
    }
}

   
