using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
    public float jumpForce = 10;
    public bool isGrounded = false;
    public Vector2 rayLenght;
    public Rigidbody2D rb2D;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    /**
    TU codigo es puta mierda*/
    void Update()
    {
        if (isGrounded)
        {
            Jump();
        }
        

       
    }

    public void Movement()
    {

        if (Input.GetKey("a"))
        {
            gameObject.transform.Translate(-20F * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            gameObject.transform.Translate(20F * Time.deltaTime, 0, 0);
        }
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb2D.AddForce(Vector2.up * jumpForce);
        }
    }

    public void isGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), rayLenght);
        Ray ray =   
    }

   
